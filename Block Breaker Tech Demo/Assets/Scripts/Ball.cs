using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public float speed = 8F;
	void Start () {
		gameObject.rigidbody.AddForce(transform.forward * (speed/2), ForceMode.VelocityChange);
		gameObject.rigidbody.AddForce(transform.right * (speed/2), ForceMode.VelocityChange);
	}
	void FixedUpdate(){
		float zSpd = -(gameObject.rigidbody.velocity.x);
		float xSpd = gameObject.rigidbody.velocity.z;
		gameObject.rigidbody.AddTorque(xSpd,0F,zSpd,ForceMode.VelocityChange);
		if(Mathf.Abs(zSpd)+Mathf.Abs(xSpd)>(speed+1)||Mathf.Abs(zSpd)+Mathf.Abs(xSpd)<(speed-1))
		{
			float newXSpeed = ((Mathf.Abs(xSpd))/(Mathf.Abs(xSpd)+Mathf.Abs(zSpd)))*speed;
			float newZSpeed = ((Mathf.Abs(zSpd))/(Mathf.Abs(xSpd+zSpd)))*speed;
			if(newXSpeed>0f&&newXSpeed<9f&&newZSpeed>0f&&newZSpeed<9f)
			{
				if(xSpd<0)
					newXSpeed*=-1;
				if(zSpd<0)
					newZSpeed*=-1;
				gameObject.rigidbody.velocity = new Vector3(newXSpeed,0,newZSpeed);
			}
		}
	}
	void OnCollisionEnter()
	{
		gameObject.audio.Play();	
	}
}
