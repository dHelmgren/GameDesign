using UnityEngine;
using System.Collections;

public class SpawnByPass : MonoBehaviour {
	public float lifetime;
	public Vector3 spawnValues;
	public GameObject hazard;
	public GameObject spawnPane;
	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "spawnWall") {
			GameController.spawnWall(spawnPane, hazard, spawnValues);
		}
	}
	
	
}