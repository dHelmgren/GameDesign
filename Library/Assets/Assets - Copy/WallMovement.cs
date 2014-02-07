using UnityEngine;
using System.Collections;

public class WallMovement : MonoBehaviour {
	public float wallSpeed = -6.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		rigidbody.velocity = new Vector3(wallSpeed ,0.0f, 0.0f);
	}
}
