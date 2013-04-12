using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	public float blockHealth = 1f;
	public GameObject levelController;
	void Start () {
	
	}
	void Update () {
	}
	void OnCollisionEnter(){
		blockHealth--;	
		if(blockHealth<1)
		{
			levelController.GetComponent<LevelController>().blockDestroyed();
			Destroy(gameObject);	
		}
	}
}
