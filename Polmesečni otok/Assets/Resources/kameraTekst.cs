using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraTekst : MonoBehaviour {
    bool isOpen = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnGUI() {
        if (isOpen)
        {
            if (GUI.Button(new Rect(10, 10, 100, 50), "Yes"))
            {
                Debug.Log("Yes");
                isOpen = false;
            }
            if(GUI.Button(new Rect(110, 10, 100, 50), "No"))
            {
                Debug.Log("No");
                isOpen = false;
            }
        }
    }
    private void OnMouseDown()
    {
        isOpen = true;
    }
}
