﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class FadeManager : MonoBehaviour {

    VRTK_HeadsetFade headsetFade;
    bool fade;

    public Transform player;

	// Use this for initialization
	void Start () {
        headsetFade = GetComponent<VRTK_HeadsetFade>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(fade)
        {
            if(headsetFade.IsFaded())
            {
                fade = false;
            }
        }

        if (!fade && headsetFade.IsFaded())
        {
            player.position = new Vector3(0, 0, 0);
            headsetFade.Unfade(3);
        }
	}

    public void Fade()
    {
        fade = true;
        headsetFade.Fade(Color.white, 3);
    }
}
