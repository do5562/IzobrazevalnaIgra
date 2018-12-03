using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    public static int Money;

    Text ScoreCounter;

    void Awake()
    {

        ScoreCounter = GetComponent<Text>();

        Money = 0;

    }


    void Update()
    {

        ScoreCounter.text = "Money: " + Money;

    }
}
