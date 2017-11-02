using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class FadeManager : MonoBehaviour {

    VRTK_HeadsetFade headsetFade;
	// Use this for initialization
	void Start () {
        headsetFade = GetComponent<VRTK_HeadsetFade>();
	}
	
	// Update is called once per frame
	void Update () {
		
        headsetFade.Fade(Color.white, 3);
	}
}
