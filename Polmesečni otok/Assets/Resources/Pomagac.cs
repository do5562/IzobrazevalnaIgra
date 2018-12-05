using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pomagac : MonoBehaviour {
    public GameObject igralec;
    public Button bt1;
    public Text displayText;
    private Collision skripta_igralca;
    int st;
    //protected List<Text> seznam_namigov;
    // Use this for initialization
    protected List<string> seznam;
    
    void Start()
    {
        
        displayText.text = "";
        seznam = new List<string>();
        st = 0;
        skripta_igralca = igralec.GetComponent<Collision>();
        seznam.Add("NAMIG 1");
        seznam.Add("NAMIG 2");
        seznam.Add("NAMIG 3");
        seznam.Add("NAMIG 4");
    }
    public void DisplayText(int i)
    {
        displayText.text = seznam[i];
    }
    private void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == bt1)
        {
            if (skripta_igralca.counter >= 2 && st <= 4)
            {

                DisplayText(st);
                st += 1;
                //Debug.Log(skripta_igralca.counter);
                skripta_igralca.counter -= 2;
                skripta_igralca.SetScoreText();
            }
            
            
            
            //Your code for button 1
            //Debug.Log("dela");

        }

        
    }
    void OnEnable()
    {
        //Register Button Events
        bt1.onClick.AddListener(() => buttonCallBack(bt1));
       
    }
    void OnDisable()
    {
        //Un-Register Button Events
        bt1.onClick.RemoveAllListeners();
        
    }

    // Update is called once per frame
    void Update () {
		
	}
    
    

}
