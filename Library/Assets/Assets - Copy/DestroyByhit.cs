using UnityEngine;
using System.Collections;

public class DestroyByhit : MonoBehaviour {
	public float lifetime;
	public Vector3 spawnValues;
	public GameObject hazard;
	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{


		if (other.tag == "deathWall")
		{
			Destroy(gameObject);
		}
	}
	

}
