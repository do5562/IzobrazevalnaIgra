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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //float nov = transform.forward * m_Speed * Time.deltaTime;
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            //vect = new Vector3(transform.forward * m_Speed * Time.deltaTime, 0, 0);
            
            m_Rigidbody.velocity = transform.forward * m_Speed;
            
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = -transform.forward * m_Speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Rotate the sprite about the Y axis in the positive direction
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * r_Speed, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Rotate the sprite about the Y axis in the negative direction
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * r_Speed, Space.World);
        }
        // Slope rotation alignment.

        RaycastHit hit;
        Ray ray = new Ray(transform.position, Vector3.down);

        if (col.Raycast(ray, out hit, 1000))
        {
            transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;

        }
        // Auto rotation.

        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, player.transform.eulerAngles.y, transform.eulerAngles.z);




        // Speed limiter which is not neceesary right now.

        /*
     
        if (rigidbody.velocity.magnitude > maxSpeed)
        {
            rigidbody.velocity = rigidbody.velocity.normalized * maxSpeed;
         
        }
        */

        // Anti jitter movement solution.

        float step = m_Speed * Time.deltaTime;
        float folX = (player.transform.position.x - transform.position.x) * step;
        float folZ = (player.transform.position.z - transform.position.z) * step;


        Vector3 v = GetComponent<Rigidbody>().velocity;

        v.x = folX;
        v.z = folZ;

        GetComponent<Rigidbody>().velocity = v;

    }
    void FixedUpdate()
    {

        
    }
}
