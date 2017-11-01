using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentToggle : MonoBehaviour {

    Animator m;

    bool idle;
    bool read;

    // Use this for initialization
    void Start()
    {
        m = gameObject.GetComponent<Animator>();

        idle = false;
        read = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            idle = false;
            read = true;
        }
        else
        {
            idle = true;
            read = false;
        }

        if (idle == true)
        {
            m.SetBool("idle", true);
        }
        else
        {
            m.SetBool("idle", false);
        }

        if (read == true)
        {
            m.SetBool("read", true);
        }
        else
        {
            m.SetBool("read", false);
        }
    }
}
