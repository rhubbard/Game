using UnityEngine;
using System.Collections;

public class PaddleController : MonoBehaviour {
	
	public float moveSpeed = 5f;
	void Update () {
		float move = Input.GetAxis("Horizontal");
		if(move<0&&transform.position.x>-4.45)
			transform.Translate(new Vector3(move*moveSpeed*Time.deltaTime,0,0));
		else if(move>0&&transform.position.x<4.45)
			transform.Translate(new Vector3(move*moveSpeed*Time.deltaTime,0,0));
	}
}
