using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    private void Start()
    {
        //Destroy(this.gameObject);

    }
    public float speed = 10f;


    void Update()
    {
        transform.Rotate(new Vector3(0,0,-1) * 50 * Time.deltaTime, Space.Self);
    }
}
