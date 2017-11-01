using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour {

    Animator m;
	float speed = 1f;
    bool walk;
    bool macarena;

	// Use this for initialization
	void Start ()
    {
        m = gameObject.GetComponent<Animator>();

        walk = false;
        macarena = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKey(KeyCode.Space))
        {
            walk = true;
            macarena = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            walk = false;
            macarena = true;
        }
        else
        {
            macarena = false;
            walk = false;
        }

        if (walk == true)
        {
            m.SetBool("walk", true);
//			speed = speed * Time.deltaTime;
//			m.transform.position = Vector3.MoveTowards (new Vector3 (m.transform.localPosition.x, m.transform.localPosition.y, m.transform.localPosition.z),
//				new Vector3 (0f, 0f, 0f), speed);
				
        }
        else
        {
            m.SetBool("walk", false);
        }

        if (macarena == true)
        {
            m.SetBool("macarena", true);
        }
        else
        {
            m.SetBool("macarena", false);
        }
    }
}
