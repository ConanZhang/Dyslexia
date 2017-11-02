using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine;

public class PlayOnTrigger : MonoBehaviour
{

    // Use this for initialization
    PlayableDirector director;
    bool press = false;
    void Start()
    {
        director = gameObject.GetComponent<PlayableDirector>();
        Pause();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Resume()
    {
        director.Resume();
    }

    public void Pause()
    {
        director.Pause();
    }
}