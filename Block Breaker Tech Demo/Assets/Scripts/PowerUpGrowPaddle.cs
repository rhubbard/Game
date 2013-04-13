using UnityEngine;
using System.Collections;

public class PowerUpGrowPaddle : MonoBehaviour {

	public float moveSpeed = 1f;
	void Start () {
		rigidbody.AddForce(0,0,-moveSpeed,ForceMode.VelocityChange);
		rigidbody.AddTorque(0,1f,0,ForceMode.VelocityChange);
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Paddle")
		{
			other.SendMessage("GrowPaddle");
			Destroy(gameObject);
		}
	}
}
