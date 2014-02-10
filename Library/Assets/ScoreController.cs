using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {

	public static int score = 0;
	
	// Use this for initialization
	void Start () {
		GameObject scoreText = Instantiate(new GameObject(), new Vector3(0.65f, 0.412f, 0.5f), Quaternion.identity) as GameObject; 
		scoreText.AddComponent<GUIText>();
		scoreText.guiText.fontSize = 36;
		score = GameController.finalScore;
		string displayScore = score.ToString();
		scoreText.guiText.text = displayScore;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(100,540,120,50), "Play Again")) {
			Application.LoadLevel("sceneballsmove");
		}

		// Make the second button.
		if(GUI.Button(new Rect(260,540,120,50), "How to Play")) {
			Application.LoadLevel("DemoControl");
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(420,540,120,50), "Main Menu")) {
			//set the nux mode boolean to true
			
			Application.LoadLevel("Main Menu");
		}
		
		if(GUI.Button(new Rect(580,540,120,50), "Game Credits")) {
			Application.LoadLevel("GameCredits");
		}
		
		if(GUI.Button(new Rect(740,540,120,50), "Quit Game")) {
			Application.Quit();
		}
		
		
	}
}
