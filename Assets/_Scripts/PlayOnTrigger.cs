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
    public FloatingText floatingText1;
    public FloatingText floatingText2;
    public FloatingText floatingText3;
    public FloatingText floatingText4;
    public FloatingText floatingText5;
    void Start()
    {
        director = gameObject.GetComponent<PlayableDirector>();
        Pause();
        floatingText.gameObject.SetActive(false);
        floatingText1.gameObject.SetActive(false);
        floatingText2.gameObject.SetActive(false);
        floatingText3.gameObject.SetActive(false);
        floatingText4.gameObject.SetActive(false);
        floatingText5.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (director.time > 75 && !press)
        {
            director.Pause();
            floatingText.gameObject.SetActive(true);
            floatingText1.gameObject.SetActive(true);
            floatingText2.gameObject.SetActive(true);
            floatingText3.gameObject.SetActive(true);
            floatingText4.gameObject.SetActive(true);
            floatingText5.gameObject.SetActive(true);
        }

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