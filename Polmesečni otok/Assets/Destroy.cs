using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour {
    public static int counter;
    public Text scoreText;
    public Text Fulltext;
    Collider m_Collider;
    GameObject ScoreBoard;
    private void Start()
    {
        counter = 0;
        scoreText.text = " ";
        Fulltext.text = " ";
        SetScoreText();
        m_Collider = GetComponent<Collider>();
    }
    public float speed = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            m_Collider.enabled = !m_Collider.enabled;
            //other.gameObject.SetActive(false);
            //ScoreBoard = GameObject.Find("ScoreBoard");
            //ScoreBoard.GetComponent<value>.score += 1;
            counter += 1;
            SetScoreText();
            

            //other.gameObject.SetActive(false);
        }
    }
    void Update()
    {
        transform.Rotate(new Vector3(0,-1,0) * 50 * Time.deltaTime, Space.Self);
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


