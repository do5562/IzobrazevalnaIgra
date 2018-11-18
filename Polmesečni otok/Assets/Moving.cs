using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {

    private Rigidbody rgbd;
    public float speed;
	// Use this for initialization
	void Start () {
        //rgbd = GetComponent < Rigidbody > ();
        speed = 20;
	}
	
	// Update is called once per frame
	void Update () {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
        //transform.Translate(1f*Time.deltaTime,0f,0f);
        //Vector3 move = new Vector3(moveHorizontal, moveVertical);
        //rgbd.AddForce(move * speed);
        //transform.Translate(speed*Input.GetAxis("Horizontal")* Time.deltaTime, 0f, speed*Input.GetAxis("Vertical")*Time.deltaTime);
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(movement);
            transform.Translate(movement * speed * Time.deltaTime, Space.World);
        }
       

    }
}
