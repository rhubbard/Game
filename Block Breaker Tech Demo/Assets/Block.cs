using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	public float blockHealth = 1f;
	public GameObject levelController;
	void OnCollisionEnter(Collision other){
		if(other.collider.tag == "Balls")
			Damage(1);
	}
	public void Damage(int x)
	{
		blockHealth-=x;
		if(blockHealth<=0)
		{
			levelController.GetComponent<LevelController>().blockDestroyed();
			Destroy(gameObject);
		}
	}
}
