using UnityEngine;
using System.Collections;

public class RotationsDemo : MonoBehaviour {

	public float PlanetRotateSpeed = -25.0f;
	public float speed = 10.0f;
	public int move = 0;
	public float xMin = 8.198614f;
	public float xMax = 32.23158f;
	public float zMin = 29.19268f;
	public float zMax = 65.94166f;
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
	
	void OnGUI()
	{
		
		if(GUI.Button(new Rect(600,50,145,50), "Back to Main Menu")) {
			Application.LoadLevel("Main Menu");
		}
		if(GUI.Button(new Rect(600,110,145,50), "Reset Player")) {
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
