/**
* GameController.cs
* Author: Sam Golloway, Janel Raab, Devin Helmgren, Stan Peck
* Class: CS 447A 
* Date: 2/11/14
* Arcade Game Project
*/
using UnityEngine;
using System.Collections;

/**
 * GameController
 * 
 * This class controls the overall functionality of the gameplay
 * It monitors how the walls and pickups spawn
 * It keeps track of the players score
 * 
 */
public class GameController : MonoBehaviour 
{

	//Variables to set up the random spawning of the walls
	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public GameObject pickups;
	public Vector3 spawnValuesPick;

	//Variables to set up the timer and score variables
	public static float timer;
	public static bool timeStarted = false;
	public static bool gameOver = false;
	//This is the offset for the score. How many points
	//per second
	public int scoreOffSet;
	public static int pickUpScoreAddtion = 0;
	public bool finalScoreSet = false;
	public static int finalScore = 0;

	//boolean to set the game on easier
	public static bool isNuxMode;

	/**
	* Start()
	* 
	* This mehtods is called at initialization.
	* 
	*/
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

	/*
	 * Update()
	 * 
	 * Update is called once per frame, and on every frame it increments
	 * the time variable of the game
	 */
	void Update()
	{
		//This chunk of code below was used during testing to 
		//allow for easy resetting of the level
		/*
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			//reset the score and time variables
			timeStarted = false;
			timer = 0;
			pickUpScoreAddtion = 0;
			finalScore = 0;
			finalScoreSet = false;
			gameOver = false;
			//Reload the level
			Application.LoadLevel(Application.loadedLevel);
		}
		*/
		//If the game has already begun, then 
		if (timeStarted == true) 
		{
			//increase the timer variable by the amount of 
			//time that has passed
			timer = timer + Time.deltaTime;
		}
	}

	/**
	* OnGUI()
	* 
	* This method displays running score on the GUI
	* 
	*/
	void OnGUI()
	{
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


	}//onGUI

	/*
	 * SpawnWaves()
	 *
	 * This method is the spawns the walls and pickups in a set pattern
	 *
	*/
	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds(spawnWait);
		while(true)
		{
			for (int i = 0;i< hazardCount;i++) 
			{	
				Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, Random.Range (-spawnValues.z, spawnValues.z));
				Quaternion spawnRotation = new Quaternion ();
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds(spawnWait);
				if(i%2 == 0)
				{

					Vector3 spawnPositionPick = new Vector3 (spawnValuesPick.x, spawnValuesPick.y, Random.Range (-spawnValuesPick.z, spawnValuesPick.z));
					Quaternion spawnRotationPick = new Quaternion ();
					Instantiate (pickups, spawnPositionPick, spawnRotation);
				}//end-if
				yield return new WaitForSeconds(spawnWait);
	    	}//end-for
		}//end-while
	}//SpawnWaves()
}//GameController
