using UnityEngine;
using System.Collections;

public class ButtonControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
	void onGUI()
	{
		GUI.Box(new Rect(10,10,100,90), "Main Menu");
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,80,20), "Start Game")) {
			Application.LoadLevel("sceneballsmove");
		}

		// Make the second button.
		if(GUI.Button(new Rect(20,70,80,20), "Control Demo")) {
			print("here we learn control");
			//Application.LoadLevel("ControlDemo");
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(20,70,80,20), "Start Game - Nux Mode")) {
			print("here we play Nux Mode");
			//Application.LoadLevel("ControlDemo");
		}
		
		if(GUI.Button(new Rect(20,70,80,20), "Game Credits")) {
			print("here we view the credits");
			//Application.LoadLevel("ControlDemo");
		}
		
		if(GUI.Button(new Rect(20,70,80,20), "Quit Game")) {
			Application.Quit();
		}
		
	}
	
}
