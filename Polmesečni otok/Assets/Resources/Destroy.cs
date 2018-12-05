using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour {
    
    
    Collider m_Collider;
    GameObject ScoreBoard;
    private void Start()
    {
        
       
        
        m_Collider = GetComponent<Collider>();
    }
    public float speed = 10f;

    private void OnTriggerEnter(Collider other)
    {
        
    }
    void Update()
    {
        transform.Rotate(new Vector3(0,-1,0) * 50 * Time.deltaTime, Space.Self);
    }
   
}


