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
	public bool wallSpwanAllowed = true;
	public static bool isNuxMode;
	public GameObject spawnPane;
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
	public static int finalScore = 0;

	void Start()
	{
		//initialize
		timeStarted = false;
		timer = 0;
		pickUpScoreAddtion = 0;
		finalScore = 0;
		finalScoreSet = false;
		gameOver = false;
		timeStarted = true;
		//Start spawning the walls
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
		  

		  if (count % 100 == 0 && WallMovement.wallSpeed < 17.0f) {
			WallMovement.wallSpeed -= 1.5f;
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
		//If you are still playing the game
		if (!gameOver) 
		{
			//calculate the current score
			score = Mathf.RoundToInt ((timer * scoreOffSet) + pickUpScoreAddtion);
			//convert it to a string in the proper formate
			string displayScore = string.Format ("{0:0}:{1: 000000}", "Score", score);
			//And display it
			GUI.Label (new Rect (10, 10, 250, 100), displayScore);
		}//end-if game is not over
		else 
		{
			//Set the final score
			if(!finalScoreSet)
			{
				score = Mathf.RoundToInt ((timer * scoreOffSet) + pickUpScoreAddtion);
				finalScore = score;
				finalScoreSet = true;
				//and go to the Game Over Scene
				Application.LoadLevel("GameOver");
			}//end-if final score not set
			
		}//end-else game over
		


		}

	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds(spawnWait);
		float lastWaveLoc = 40 + WallMovement.wallSpeed;
		spawnWall (spawnPane,hazard,spawnValues);
		while(true)
		{
			for (int i = 0;i< hazardCount;i++)
			{	
				//Set the hazard between set spawnValues -z and z, where z is the width of the stage
				
				
				
				yield return new WaitForSeconds(spawnWait);
				if(i%2 == 0)
				{
					Vector3 spawnPositionPick = new Vector3 (spawnValuesPick.x, spawnValuesPick.y, Random.Range (-spawnValuesPick.z, spawnValuesPick.z));
					Quaternion spawnRotationPick = new Quaternion ();
					Instantiate (pickups, spawnPositionPick, spawnRotationPick);
				}
				
				yield return new WaitForSeconds(spawnWait);
			}//for
			lastWaveLoc += WallMovement.wallSpeed;
		}//while
	}
	public static void spawnWall(GameObject spawnPane, GameObject hazard, Vector3 spawnValues){
		int numWalls = 0;
		float spawnLoc = 0;
		while (numWalls < 2){
			float guy = Random.Range (0, 10) * 5 - 25;
			if(guy + 12 >= spawnLoc || guy - 12 <= spawnLoc){
				Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, guy);
				Quaternion spawnRotation = new Quaternion ();
				Instantiate (hazard, spawnPosition, spawnRotation);
				numWalls++;
			}

		}
		Vector3 spawnPanePos = new Vector3 (spawnValues.x, spawnValues.y, -40);
		Quaternion spawnPaneRot = new Quaternion ();
		Instantiate (spawnPane, spawnPanePos, spawnPaneRot);
	}
}
