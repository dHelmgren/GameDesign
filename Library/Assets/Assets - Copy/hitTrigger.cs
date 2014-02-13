using UnityEngine;
using System.Collections;

public class hitTrigger : MonoBehaviour 
{
	public float pushSpeed = -4.0f;


	void OnTriggerEnter(Collider other)
	{
		Debug.Log (other);
		if (other.tag == "Player" || other.tag == "spawnWall") {

				} 
				else if (other.tag == "pickUp") 
				{
						WallMovement.wallSpeed = -3.0f;
						GameController.count = 0;
						Destroy (other.gameObject);
				} 
		else if (other.tag == "deathWall") {
			GameController.gameOver = true;
			WallMovement.wallSpeed = -6.0f;
					Destroy(GameObject.Find ("RedBall"));
					Destroy(GameObject.Find ("BlueBall"));
					Destroy(GameObject.Find ("tether 1"));

				}
		else {	

				if(other.tag == "Wall" && GameController.isNuxMode == true)
				{
				//ha do nohting a;ljfsa;nhugyi
				}
			else{
					GameObject.Find ("BlueBall").GetComponent<Rotations>().clockWise =!(GameObject.Find ("BlueBall").GetComponent<Rotations>().clockWise);
					GameObject.Find ("RedBall").GetComponent<Rotations>().clockWise =!(GameObject.Find ("RedBall").GetComponent<Rotations>().clockWise);
				GameObject.Find ("tether 1").GetComponent<Rotations>().clockWise =!(GameObject.Find ("tether 1").GetComponent<Rotations>().clockWise);
			     } 
			}
	}

}
