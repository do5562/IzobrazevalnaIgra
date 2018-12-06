using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moving : MonoBehaviour {
    //public Vector3 vect;
    public Text scoreText;
    public Text Fulltext;
    public int m_Speed = 20;
    public float r_Speed = 50.0f;
    public GameObject player;
    Renderer render;
    Animator animator;
    Collider m_Collider;
    
    public Collider col;
    public int tocke;

    void Start()
    {
        animator = player.GetComponent<Animator>();
        
        scoreText.text = " ";
        Fulltext.text = " ";
        SetScoreText();
        m_Collider = GameObject.FindGameObjectWithTag("Destroyables").GetComponent<Collider>();
        render = GameObject.FindGameObjectWithTag("Destroyables").GetComponent<SpriteRenderer>();
        
       
        //Fetch the Rigidbody component you attach from your GameObject
        
        //Set the speed of the GameObject
        
    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        
       
        if (collision.gameObject.CompareTag("Destroyables"))
        {
            tocke += 1;
           
            SetScoreText();
            //sprite.enabled = false;
            collision.gameObject.SetActive(false);
            m_Collider.enabled = !m_Collider.enabled;
            

        }

    }


    void Update()
    {
        
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            
            animator.SetBool("isPressed", true);
        }
        
        else
        {
            animator.SetBool("isPressed", false);
        }
        var x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxisRaw("Vertical") * Time.deltaTime * 20.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        

    }
    public void SetScoreText()
    {
        scoreText.text = "Score: " + tocke.ToString();
        if (tocke >= 7)
        {
            Fulltext.text = "Vse točke!";
        }
    }
    /// <summary>
    /// 
    /// </summary>

}
