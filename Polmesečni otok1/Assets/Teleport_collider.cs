using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_collider : MonoBehaviour {
    public GameObject player;
    public Transform teleportTarget;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = teleportTarget.transform.position;
    }

}
