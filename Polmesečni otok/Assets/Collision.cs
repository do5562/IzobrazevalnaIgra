using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour {
    protected static int counter;
    public Text scoreText;
    public Text Fulltext;
    

    private void Start()
    {
        counter = 0;
        scoreText.text = " ";
        Fulltext.text = " ";
        SetScoreText();
        
        //skret= RFAIPP_Toilet_Closed.GetComponent<Collider>();
        //papirCol = Papir.GetComponent<Collider>();
    }

    private void Update() {
        //Debug.Log(counter);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Destroyables"))
        {
            other.gameObject.SetActive(false);
            counter += 1;
            SetScoreText();
        }
        
    }
    
    void SetScoreText()
    {
        scoreText.text = "Score: " + counter.ToString();
        if (counter >= 7)
        {
            Fulltext.text = "Vse točke!";
        }
    }






}
