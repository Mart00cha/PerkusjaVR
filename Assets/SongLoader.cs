using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;  


public class SongLoader : MonoBehaviour {
	enum BUTTON_TYPES {
		MIDDLE_BUTTON = 0
	};

	Dictionary<int, IList> buttons;

	void Start () {
		buttons = new Dictionary<int, IList>();
		LoadButtonsFromFile ("Assets/Resources/Songs/song.txt");
	}
	
	public IList GetButtons(int time) {
		if(buttons.ContainsKey(time)) {
			return buttons[time];
		}
		else {
			Debug.Log ("No entry for: "+time);
			return new ArrayList();
		}
	}

	void LoadButtonsFromFile(string filename) {
		StreamReader inputStream = new StreamReader(filename);
		while(!inputStream.EndOfStream) {
			string line = inputStream.ReadLine( );

			string[] entries = line.Split(' ');
			int buttonId = int.Parse(entries[0]);
			int secondOfPlaying = int.Parse(entries[1]);
			AddButton(buttonId, secondOfPlaying);
		}

		inputStream.Close( );  
	}

	void AddButton(int buttonId, int secondOfPlaying) {
		GameObject button = (GameObject) Instantiate(Resources.Load("Prefabs/MiddleButton"), new Vector3(0,0,0), Quaternion.identity);
		GameObject plane = GameObject.Find("TrackButton").GetComponent<GameObject> ();
//		button.transform.parent = 
		button.SetActive (false);
		if(!buttons.ContainsKey(secondOfPlaying)) {
			buttons [secondOfPlaying] = new ArrayList ();
		}
		buttons[secondOfPlaying].Add(button);
	}
}
