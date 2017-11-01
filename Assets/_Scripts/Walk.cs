using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour {

	Transform m;
	public float speed = 100f;
	// Use this for initialization
	void Start () {
		m = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		speed = speed * Time.deltaTime*10;
		print (m.localPosition);
//		m.transform.position = Vector3.MoveTowards (new Vector3 (m.transform.localPosition.x, m.transform.localPosition.y, m.transform.localPosition.z),
//						new Vector3 (0f, 0f, 0f), speed);

		m.localPosition.Set (0f, 0f, 0f);
		print (m.localPosition);
		}
}
