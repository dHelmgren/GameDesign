using UnityEngine;
using System.Collections;

public class WallMovement : MonoBehaviour {
	public static float wallSpeed = -4.0f;
	public float tumble;
	// Use this for initialization
	void Start () {
	
		//give the pick up a rotation
		if (gameObject.tag == "pickUp") 
		{
			rigidbody.angularVelocity = Random.insideUnitSphere * tumble;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		rigidbody.velocity = new Vector3(wallSpeed ,0.0f, 0.0f);

	}
}
