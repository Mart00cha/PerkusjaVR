using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    SongPlayer player;
    ScoreManager scoreManager;
    string[] songs = {"song1", "song2", "song3"};
    
	void Start () {
	    player = GameObject.Find("SongManager").GetComponent<SongPlayer>();
        scoreManager = GameObject.Find("Score").GetComponent<ScoreManager>();
    }
	
	void Update () { }

    void OnSong(int songId)
    {
        player.StopSong();
        scoreManager.Reset();
        player.PlaySong(songs[songId]);
    }

    public void OnSong1() { OnSong(0); }
    public void OnSong2() { OnSong(1); }
    public void OnSong3() { OnSong(2); }

    public void OnFreestyle()
    {
        player.StopSong();
        scoreManager.Reset();
    }
}
