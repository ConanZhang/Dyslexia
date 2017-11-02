using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine;

public class PlayOnTrigger : MonoBehaviour {

    // Use this for initialization
    public PlayableDirector director;
    bool press = false;
	void Start () {
        director = gameObject.GetComponent<PlayableDirector>();
	}
	
	// Update is called once per frame
	void Update () {
        //director.Pause();
        //print(Time.time);

        if (Input.GetKey(KeyCode.Space))// && !press)
        {
            print("presds");
            press = true;
            director.Resume();
        }

        if (Time.time > 14 && ! press)
        {
            director.Pause();
           // print(director.GetComponent<AudioSource>());
        }
        
    }
}

