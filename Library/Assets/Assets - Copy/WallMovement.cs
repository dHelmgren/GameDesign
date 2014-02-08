using UnityEngine;
using System.Collections;

public class WallMovement : MonoBehaviour {
	public static float wallSpeed = -6.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		rigidbody.velocity = new Vector3(wallSpeed ,0.0f, 0.0f);

	}
}
