using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {

	public float blocksLeft;
	public GameObject winCamera;
	void Start () {
	}
	void Update () {
	}
	public void blockDestroyed()
	{
		blocksLeft--;
		if(blocksLeft == 0)
		{
			winCamera.SetActive(true);
		}
	}
}
