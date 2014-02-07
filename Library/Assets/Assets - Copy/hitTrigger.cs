using UnityEngine;
using System.Collections;

public class hitTrigger : MonoBehaviour 
{
	public float pushSpeed = -6.0f;


	void OnTriggerEnter(Collider other)
	{

		if (other.tag == "Player") {
				} 
			else if (other.tag == "pickUp")
			{
			Destroy(other.gameObject);
			}
		else {
				Destroy (other.gameObject);
				Destroy(GameObject.Find ("Ball1"));
				Destroy(GameObject.Find ("ball2"));
				Destroy (GameObject.Find ("Tether"));
			//Debug.Log ("hey");
			//GameObject.Find ("Ball1").rigidbody.velocity =  new Vector3 (pushSpeed, 0.0f, 0.0f);
			//GameObject.Find ("ball2").rigidbody.velocity =  new Vector3 (pushSpeed, 0.0f, 0.0f);
			//GameObject.Find ("Tether").rigidbody.velocity =  new Vector3 (pushSpeed, 0.0f, 0.0f);
			//GameObject.Find ("Ball1").GetComponent<Rotations>().washit=true;
			//GameObject.Find ("ball2").GetComponent<Rotations>().washit=true;
			//GameObject.Find ("Tether").GetComponent<Rotations>().washit=true;
		


						
				}
	}
	void onTriggerExit(Collider other)
	{	

		if (other.tag == "Player") {
				} else {
						GameObject.Find ("Ball1").rigidbody.velocity = new Vector3 (0.0f, 0.0f, 0.0f);
						GameObject.Find ("ball2").rigidbody.velocity = new Vector3 (0.0f, 0.0f, 0.0f);
						GameObject.Find ("Tether").rigidbody.velocity = new Vector3 (0.0f, 0.0f, 0.0f);
				}
	}

}
