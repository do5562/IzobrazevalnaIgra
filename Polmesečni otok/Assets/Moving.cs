using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {


    public float moveSpeed = 0.3F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public float rotateSpeed = 3.0F;
    private Vector3 moveDirection = Vector3.zero;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * moveSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * moveSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -2, 0);
            //transform.position -= transform.right * moveSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 2, 0);
            //transform.position += transform.right * moveSpeed;
        }

    }

}
