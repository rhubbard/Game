using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {
	
	public float moveSpeed = 5f;
	void Start () {
	
	}
	
	void Update () {
		float move = Input.GetAxis("Horizontal");
		if(transform.position.x>-4.45&&transform.position.x<4.45)
			transform.Translate(new Vector3(move*moveSpeed*Time.deltaTime,0,0));
		else if(transform.position.x<-4.45)
		{
			transform.Translate(new Vector3(.05f,0,0));
		}
		else if(transform.position.x>4.45)
		{
			transform.Translate(new Vector3(-.05f,0,0));
		}
	}
}
