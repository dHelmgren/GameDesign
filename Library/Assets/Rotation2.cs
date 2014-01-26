using UnityEngine;
using System.Collections;

public class Rotation2 : MonoBehaviour {
	
	public float PlanetRotateSpeed = -25.0f;
	public float speed = 10.0f;
	int move = 0;
	public bool movement = true;
	public bool clockWise = false;
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) == true ) 
		{
			clockWise = !clockWise;
		}
		
		else if (Input.GetKeyDown(KeyCode.A) == true ) 
		{
			movement = !movement;
			
		}
		else if(Input.GetKeyDown(KeyCode.S) == true)
		{
			movement = !movement;
			clockWise = !clockWise;
		}
	}
	void FixedUpdate() 
	{
		
		
		if (movement) 
		{
			if (clockWise) 
			{
				transform.RotateAround (GameObject.Find ("Ball1").transform.position, (-1) * Vector3.up, speed * Time.deltaTime);
			} 
			else 
			{
				transform.RotateAround (GameObject.Find ("Ball1").transform.position, Vector3.up, speed * Time.deltaTime);
			}
		}
	}
}
