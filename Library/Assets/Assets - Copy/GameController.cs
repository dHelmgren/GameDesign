using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public GameObject pickups;
	public Vector3 spawnValuesPick;
	void Start()
	{
		StartCoroutine (SpawnWaves ());
	}
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.R)) {

			Application.LoadLevel(Application.loadedLevel);
				}
	}
	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds(spawnWait);
		while(true)
		{
			for (int i = 0;i< hazardCount;i++) 
			{	
				//Set the hazard between set spawnValues -z and z, where z is the width of the stage
				/*Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, Random.Range (-spawnValues.z, spawnValues.z));
				Quaternion spawnRotation = new Quaternion ();
				Instantiate (hazard, spawnPosition, spawnRotation);*/
				//int negWall = Random.Range(0,10);
				for(int j = 0; j <= 3; j += 1)
				{
					spawnWall (Random.Range (0,10)*5 - 25);
				}
				yield return new WaitForSeconds(spawnWait);
				if(i%2 == 0)
				{
					Vector3 spawnPositionPick = new Vector3 (spawnValuesPick.x, spawnValuesPick.y, Random.Range (-spawnValuesPick.z, spawnValuesPick.z));
					Quaternion spawnRotationPick = new Quaternion ();
					Instantiate (pickups, spawnPositionPick, spawnRotationPick);
				}
				yield return new WaitForSeconds(spawnWait);
			}//for
		}//while
	}
	void spawnWall(float zLoc){
			Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, zLoc);
			Quaternion spawnRotation = new Quaternion ();
			Instantiate (hazard, spawnPosition, spawnRotation);
		}
}
