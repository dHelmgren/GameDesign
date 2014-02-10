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
	public static float timer;
	public static bool timeStarted = false;

	public static bool gameOver = false;
	public float speedIncriment = -.1f;
	public static int count = 0; 

	//This is the offset for the score. How many points
	//per second
	public int scoreOffSet;
	public static int pickUpScoreAddtion = 0;
	public bool finalScoreSet = false;
	public int finalScore = 0;

	void Start()
	{
		//Start the timer
		timeStarted = true;
		StartCoroutine (SpawnWaves ());
	}
	void Update()
	{
		if (Input.GetKeyDown (KeyCode.R)) {
			//reset the score and time variables
			timeStarted = false;
			timer = 0;
			pickUpScoreAddtion = 0;
			finalScore = 0;
			finalScoreSet = false;
			gameOver = false;
			Application.LoadLevel(Application.loadedLevel);

				}
		if (timeStarted == true) {
			timer = timer + Time.deltaTime;
			}
		  

		  if (count % 100 == 0) {
			WallMovement.wallSpeed -= Mathf.Log ((count+.5f)/50000.0f, 2.7182818284f)+8.0f;
				}
		count++;


	}

	void OnGUI(){
		//This code below is if you want to display the time in the game
			//int minutes = Mathf.FloorToInt (timer / 60F);
			//int seconds = Mathf.FloorToInt (timer - minutes * 60);

			//string niceTime = string.Format ("{0:00}:{1:00}", minutes, seconds);
			//GUI.Label (new Rect (10, 10, 250, 100), niceTime);

		//This code is if you want to display the score for the round
		int score = 0;
		if (!gameOver) 
		{
			score = Mathf.RoundToInt ((timer * scoreOffSet) + pickUpScoreAddtion);
			string displayScore = string.Format ("{0:0}:{1: 000000}", "Score", score);
			GUI.Label (new Rect (10, 10, 250, 100), displayScore);
		}
		else 
		{
			//Display a GameOver Message
			if(!finalScoreSet)
			{
				score = Mathf.RoundToInt ((timer * scoreOffSet) + pickUpScoreAddtion);
				finalScore = score;
				finalScoreSet = true;
			}
			string displayScore = string.Format ("{0:0}:{1: 0}", "Final Score", finalScore);
			GUI.Label(new Rect(300,300,250,500), "Game Over!!");
			GUI.Label(new Rect(300,350,250,500), displayScore);

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
