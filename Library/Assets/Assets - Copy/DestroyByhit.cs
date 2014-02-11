using UnityEngine;
using System.Collections;

public class DestroyByhit : MonoBehaviour {
	public float lifetime;
	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{


		if (other.tag == "deathWall")
		{
			Destroy(gameObject);
		}
		else if (other.tag == "spawnWall") {
			GameController.spawnWall();
		}
	}
	

}
