using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour {

    public bool isCorrect;

    public Vector3 center;
    public float radius;
    Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if((center - transform.position).sqrMagnitude > radius * radius)
        {
            rigidbody.velocity = Vector3.Reflect(rigidbody.velocity, center - transform.position);
            rigidbody.position = center + (transform.position - center).normalized * radius * 0.999f;
        }
        rigidbody.AddForce(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2));
	}

    void OnDrawGizmosSelected() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(center, radius);
    }
}
