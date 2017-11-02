using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine;

public class PlayOnTrigger : MonoBehaviour
{

    // Use this for initialization
    PlayableDirector director;
    bool press = false;
    public int count = 0;
    public FloatingText floatingText;
    void Start()
    {
        director = gameObject.GetComponent<PlayableDirector>();
        Pause();
        floatingText.GetComponent<Rigidbody>().transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (director.time > 75 && !press)
            director.Pause();

        if (director.time > 15 && !press)
            floatingText.GetComponent<Rigidbody>().transform.localScale = new Vector3 (1, 1, 1);

        if (count == 4)
        {
            press = true;
            director.Resume();
        }
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