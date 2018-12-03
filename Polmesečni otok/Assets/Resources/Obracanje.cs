using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obracanje : MonoBehaviour {
    public Transform target;
    public float speed = 10f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, -1, 0) * 50 * Time.deltaTime, Space.Self);
    }
}
