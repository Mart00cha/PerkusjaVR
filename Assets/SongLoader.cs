using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;  


public class SongLoader : MonoBehaviour {
	enum BUTTON_TYPES {
		LEFT_BUTTON = 0,
		MIDDLE_BUTTON = 1,
		RIGHT_BUTTON = 2,
		TOP_LEFT = 3,
		TOP_RIGHT = 4
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
		GameObject button = (GameObject) Instantiate(Resources.Load("Prefabs/MiddleButton"));
		button.SetActive (false);
		GameObject plane = GameObject.Find ("Plane");

		button.transform.parent = plane.transform;
		button.transform.localRotation = new Quaternion (0, 0, 0, 1);

		Material leftMaterial = Resources.Load("Materials/LeftButton", typeof(Material)) as Material;
		Material middleMaterial = Resources.Load("Materials/MiddleButton", typeof(Material)) as Material;
		Material rightMaterial = Resources.Load("Materials/RightButton", typeof(Material)) as Material;
		Material topLeftMaterial = Resources.Load("Materials/TopLeftButton", typeof(Material)) as Material;
		Material topRightMaterial = Resources.Load("Materials/TopRightButton", typeof(Material)) as Material;
		switch ((BUTTON_TYPES)buttonId) {
		case BUTTON_TYPES.LEFT_BUTTON:
			button.transform.localPosition = new Vector3 (-4, 0, 6);
			button.gameObject.GetComponent<Renderer> ().material = leftMaterial;
			break;
		case BUTTON_TYPES.MIDDLE_BUTTON:
			button.transform.localPosition = new Vector3 (0, 0, 6);
			button.gameObject.GetComponent<Renderer> ().material = middleMaterial;
			break;
		case BUTTON_TYPES.RIGHT_BUTTON:
			button.transform.localPosition = new Vector3 (4, 0, 6);
			button.gameObject.GetComponent<Renderer> ().material = rightMaterial;
			break;
		case BUTTON_TYPES.TOP_LEFT:
			button.transform.localPosition = new Vector3 (-2, 0, 6);
			button.gameObject.GetComponent<Renderer> ().material = topLeftMaterial;
			break;
		case BUTTON_TYPES.TOP_RIGHT:
			button.transform.localPosition = new Vector3 (2, 0, 6);
			button.gameObject.GetComponent<Renderer> ().material = topRightMaterial;
			break;
		default:
			button.transform.localPosition = new Vector3 (0, 0, 6);
			button.gameObject.GetComponent<Renderer> ().material = topRightMaterial;
			break;
		}


		if(!buttons.ContainsKey(secondOfPlaying)) {
			buttons [secondOfPlaying] = new ArrayList ();
		}
		buttons[secondOfPlaying].Add(button);
	}
}
