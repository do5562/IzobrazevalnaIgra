using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    //public Vector3 vect;
    Rigidbody m_Rigidbody;
    public int m_Speed = 20;
    public float r_Speed = 50.0f;
    public GameObject player;
    
    public Collider col;

    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        
    }
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 20.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
    /// <summary>
    /// 
    /// </summary>
   
}
