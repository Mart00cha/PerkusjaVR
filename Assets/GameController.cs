using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    SongPlayer player;
    ScoreManager scoreManager;
    
	void Start () {
	    player = GameObject.Find("SongManager").GetComponent<SongPlayer>();
        scoreManager = GameObject.Find("Score").GetComponent<ScoreManager>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnSong()
    {
        print("loooool");
        player.StopSong();
        scoreManager.Reset();
        player.PlaySong("Assets/Resources/Songs/song.txt");
    }
}
