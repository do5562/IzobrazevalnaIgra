using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    //public Vector3 vect;
    
    public int m_Speed = 20;
    public float r_Speed = 50.0f;
    public GameObject player;
    Animator animator;
    public Collider col;

    void Start()
    {
        animator = player.GetComponent<Animator>();
        //Fetch the Rigidbody component you attach from your GameObject
        
        //Set the speed of the GameObject
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            
            animator.SetBool("isPressed", true);
        }
        
        else
        {
            animator.SetBool("isPressed", false);
        }
        var x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxisRaw("Vertical") * Time.deltaTime * 20.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        
        
    }
    /// <summary>
    /// 
    /// </summary>
   
}
