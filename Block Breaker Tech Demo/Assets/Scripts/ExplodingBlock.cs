using UnityEngine;
using System.Collections;

public class ExplodingBlock : MonoBehaviour {

	public float blockHealth = 1f;
	public int blastStrength = 2;
	public float blastRadius = 2f;
	public GameObject levelController;
	void OnCollisionEnter(Collision other){
		if(other.collider.tag == "Balls")
			Damage(1);
	}
	public void Damage(int d)
	{
		blockHealth-=d;
		if(blockHealth<=0)
		{
			levelController.GetComponent<LevelController>().blockDestroyed();
			Collider[] colliders = Physics.OverlapSphere(transform.position,blastRadius);
			for(int x = 0; x<colliders.Length;x++)
			{
				if(colliders[x].gameObject != gameObject&&colliders[x].tag == "Blocks")
					colliders[x].SendMessage("Damage",blastStrength);
			}
			Destroy(gameObject);
		}
	}
}