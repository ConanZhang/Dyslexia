using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour {

	Transform m;
	Collider c;
	public float speed = 100f;
	// Use this for initialization
	void Start () {
		m = gameObject.GetComponent<Transform>();
		c = gameObject.GetComponent<Collider> ();
	}
	
	// Update is called once per frame
	void Update () {

		print (m.name);
		//transform.localPosition.Set (m.localPosition.x+1, m.localPosition.y, m.localPosition.z);

		//transform.position = new Vector3 (0, 0, 0);

		transform.Translate (-Time.deltaTime/2, 0, Time.deltaTime/15, Camera.main.transform);

		print (c.isTrigger);
		}
}
