using UnityEngine;
using System.Collections;

public class Rotations : MonoBehaviour {

	 public float PlanetRotateSpeed = -25.0f;
	 public float speed = 10.0f;
	int move = 0;
	public bool movement = false;
	public bool clockWise = false;
	public bool washit = false;
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) == true ) 
		{
			clockWise = !clockWise;
			washit = false;
			rigidbody.velocity = new Vector3 (0.0f, 0.0f, 0.0f);
		}

		else if (Input.GetKeyDown(KeyCode.A) == true ) 
		{
			movement = !movement;
			washit = false;
			rigidbody.velocity = new Vector3 (0.0f, 0.0f, 0.0f);
			
		}
		else if(Input.GetKeyDown(KeyCode.S) == true)
		{
			movement = !movement;
			clockWise = !clockWise;
			washit = false;
			rigidbody.velocity = new Vector3 (0.0f, 0.0f, 0.0f);
		}
	}
	void FixedUpdate() 
	{
	
		if (!washit) {
						if (movement) {
								if (clockWise) {
										transform.RotateAround (GameObject.Find ("ball2").transform.position, (-1) * Vector3.up, speed * Time.deltaTime);
								} else {
										transform.RotateAround (GameObject.Find ("ball2").transform.position, Vector3.up, speed * Time.deltaTime);
								}
						} else {

								if (clockWise) {
										transform.RotateAround (GameObject.Find ("Ball1").transform.position, (-1) * Vector3.up, speed * Time.deltaTime);
								} else {
										transform.RotateAround (GameObject.Find ("Ball1").transform.position, Vector3.up, speed * Time.deltaTime);
								}


						}
				}

    }
}
