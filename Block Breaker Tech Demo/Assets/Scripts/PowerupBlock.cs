using UnityEngine;
using System.Collections;

public class PowerupBlock : MonoBehaviour {

	public float blockHealth = 1f;
	public GameObject levelController;
	public GameObject[] powerUps;
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
			int randNum = (int)(Random.value*powerUps.Length);
			Instantiate(powerUps[randNum], transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}
}