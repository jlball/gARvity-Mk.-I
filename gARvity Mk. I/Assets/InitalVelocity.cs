using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitalVelocity : MonoBehaviour {

    public Transform trAttractor;
    public float forceIntensity = 100.0f;

	// Use this for initialization
	void Start () {
        Rigidbody rb = GetComponent<Rigidbody>();

        transform.LookAt(trAttractor);
        Vector3 forceTangent = new Vector3(Random.value, Random.value, 0);
        Debug.Log(forceTangent);

        rb.AddRelativeForce(forceTangent * forceIntensity, ForceMode.VelocityChange);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
