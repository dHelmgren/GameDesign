using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	

	void OnGUI()
	{
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(100,440,120,50), "Start Game")) {
			Application.LoadLevel("sceneballsmove");
		}

		// Make the second button.
		if(GUI.Button(new Rect(260,440,120,50), "How to Play")) {
			Application.LoadLevel("DemoControl");
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(420,440,120,50), "Play Nux Mode")) {
			//set the nux mode boolean to true
			
			Application.LoadLevel("sceneballsmove");
		}
		
		if(GUI.Button(new Rect(580,440,120,50), "Game Credits")) {
			Application.LoadLevel("GameCredit");
		}
		
		if(GUI.Button(new Rect(740,440,120,50), "Quit Game")) {
			Application.Quit();
		}
		
		
	}
	
}
