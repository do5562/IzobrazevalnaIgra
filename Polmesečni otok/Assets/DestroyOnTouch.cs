using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour {
    //  GameObject player;
    // Use this for initialization
    private  int tocke;
    private Moving skripta;
    private GameObject player;

	void Start () {
        player = GameObject.Find("Player");
        skripta = player.GetComponent<Moving>();
        
        //Debug.Log(tocke);
// player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
       // Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name=="Player" && tocke >=9)
        {
            //Debug.Log("COLLISION");
            Destroy(gameObject);
        }
    }
    
    // Update is called once per frame
    void Update () {
        tocke = skripta.tocke;
        //Debug.Log(tocke);
    }
}
