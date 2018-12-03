using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour {

    public GameObject player;
    public Transform teleportTarget;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.y <= 16)
        {
            player.transform.position = teleportTarget.position;
        }
    }
}
