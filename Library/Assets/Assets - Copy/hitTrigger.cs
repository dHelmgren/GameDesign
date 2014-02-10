using UnityEngine;
using System.Collections;

public class hitTrigger : MonoBehaviour 
{
	public float pushSpeed = -6.0f;


	void OnTriggerEnter(Collider other)
	{
		Debug.Log (other);
		if (other.tag == "Player") {

				} 
		else if (other.tag == "pickUp") {
						WallMovement.wallSpeed = -3.0f;
						GameController.count = 0;
						Destroy (other.gameObject);
				} 
		else if (other.tag == "deathWall") {
					Destroy(GameObject.Find ("Ball1"));
					Destroy(GameObject.Find ("ball2"));
					Destroy(GameObject.Find ("Tether"));

				}
		else {
			GameObject.Find ("Ball1").GetComponent<Rotations>().clockWise =!(GameObject.Find ("Ball1").GetComponent<Rotations>().clockWise);
			GameObject.Find ("ball2").GetComponent<Rotations>().clockWise =!(GameObject.Find ("ball2").GetComponent<Rotations>().clockWise);
			GameObject.Find ("Tether").GetComponent<Rotations>().clockWise =!(GameObject.Find ("Tether").GetComponent<Rotations>().clockWise);

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
