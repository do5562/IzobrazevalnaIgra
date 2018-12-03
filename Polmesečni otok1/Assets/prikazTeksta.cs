using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prikazTeksta : MonoBehaviour {
    bool isOpen = false;
    string tekst = "Navodila za igro so sledeča: Moraš pobrati vse kovance,\n ki so na poti v točno določenem zaporedju.";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnGUI()
    {
        if (isOpen)
        {
            if (GUI.Button(new Rect(10, 10, 500, 200), tekst))
            {
                isOpen = false;
            }
            
        }
    }
    private void OnMouseDown()
    {
        isOpen = true;
    }
}

