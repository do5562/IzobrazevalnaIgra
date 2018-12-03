using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour {
    public  int counter;
    public Text scoreText;
    public Text Fulltext;
    public SpriteRenderer rend;

    private void Start()
    {
        
        scoreText.text = " ";
        Fulltext.text = " ";
        SetScoreText();
        rend = gameObject.GetComponent<SpriteRenderer>();
        //skret= RFAIPP_Toilet_Closed.GetComponent<Collider>();
        //papirCol = Papir.GetComponent<Collider>();
    }

    private void Update() {
        //Debug.Log(counter);
    }

    
    
    public void SetScoreText()
    {
        scoreText.text = "Score: " + counter.ToString();
        if (counter >= 7)
        {
            Fulltext.text = "Vse točke!";
        }
    }






}
