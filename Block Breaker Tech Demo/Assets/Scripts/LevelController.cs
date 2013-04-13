using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {

	public float blocksLeft;
	public GameObject winText;
	public void blockDestroyed()
	{
		blocksLeft--;
		if(blocksLeft == 0)
			winText.SetActive(true);
	}
}
