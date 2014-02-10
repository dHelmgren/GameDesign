using UnityEngine;
using System.Collections;

public class WallMovement : MonoBehaviour {
<<<<<<< HEAD
	public float wallSpeed = -6.0f;
	public float tumble;
=======
	public static float wallSpeed = -6.0f;

>>>>>>> 0598faa9102d6816e4949f764a0ce217ebb94f73
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
