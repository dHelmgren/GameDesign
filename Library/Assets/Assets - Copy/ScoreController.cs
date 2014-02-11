/**
 * ScoreController.cs
 * Author: Janel Raab
 * Class: CS 447A 
 * Date: 2/11/14
 * Arcade Game Project
 */
using UnityEngine;
using System.Collections;


/**
 * ScoreController
 * 
 * This class controls the behavior for the End Game Scene
 * It displays the final score and options for the player
 * can take
 * 
 */
public class ScoreController : MonoBehaviour
{
		//varibal used to set the end score
		public static int score = 0;
	
		/**
		 * Start()
		 * 
		 * This mehtods is called at initialization.
		 * 
		 */
		void Start ()
		{
				//create a text object at the right location
				GameObject scoreText = Instantiate (new GameObject (), new Vector3 (0.65f, 0.412f, 0.5f), Quaternion.identity) as GameObject; 
				scoreText.AddComponent<GUIText> ();
				//Set the size of the text
				scoreText.guiText.fontSize = 36;
				//get the final score value from GameController
				score = GameController.finalScore;
				//turn the score int into a string
				string displayScore = score.ToString ();
				//Set the scoreText to display the final score
				scoreText.guiText.text = displayScore;
	
		}//Start
	
		// Update is called once per frame
		void Update ()
		{
			//This method does nothing
		}

		/**
		 * OnGUI()
		 * 
		 * This method displays the buttons on the GUI of the Scene
		 * And handles what each button does
		 * 
		 */
		void OnGUI ()
		{
				//Create the Play again button, and if it is pressed
				if (GUI.Button (new Rect (100, 540, 120, 50), "Play Again")) 
				{
					//re-load the game level
					Application.LoadLevel ("sceneballsmove");
				}

				//Create the How to play button, and if it is pressed
				if (GUI.Button (new Rect (260, 540, 120, 50), "How to Play")) 
				{
					//Load the demo control scene
					Application.LoadLevel ("DemoControl");
				}

				//Create the Main Menu again button, and if it is pressed
				if (GUI.Button (new Rect (420, 540, 120, 50), "Main Menu")) 
				{
					//Load the main menu scene
					Application.LoadLevel ("Main Menu");
				}
		
				if (GUI.Button (new Rect (580, 540, 120, 50), "Game Credits")) 
				{
					//Load the Game Credits Scene
					Application.LoadLevel ("GameCredits");
				}
		
				if (GUI.Button (new Rect (740, 540, 120, 50), "Quit Game")) 
				{
						//Quit the Game
						Application.Quit ();
				}
			
		}//onGUI

}//ScoreController
