using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayCont : MonoBehaviour
{
    private bool salt = false;
    private bool invul = false;
    private bool mal = false;
    private int OldRot = 0;
    private float vel = 20;
    public int score;
    public TextMeshProUGUI textPro;
    public int vida;
    public delegate void PerdraVidaBoss();
    public event PerdraVidaBoss  OnPerdraVidaBoss;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Comprovar", 0.1f, 0.1f);
        //textPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textPro.text = "Score : " + score;
        if (Input.GetKey("d"))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector3(vel, this.GetComponent<Rigidbody2D>().velocity.y, 0);
        }
        else if (Input.GetKey("a"))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector3(-vel, this.GetComponent<Rigidbody2D>().velocity.y, 0);
        }
        else {
            this.GetComponent<Rigidbody2D>().velocity = new Vector3(0, this.GetComponent<Rigidbody2D>().velocity.y, 0);
        }
        if (Input.GetKeyDown("w")) {
            if (salt) {
                this.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 300, 0));
                salt = false;
            }
        }


        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Terra") {
            salt = true;
        }
        if ((collision.transform.tag == "Enemic" || collision.transform.tag == "Boss") && invul == false) {
            if (mal == false)
            {
                this.vida -= 1;
                if (vida <= 0)
                {
                    Destroy(this.gameObject);
                    loadSeen();
                }
                invul = true;
                Invoke("tornamal", 1f);
            }
            else if (collision.transform.tag == "Enemic") {
                Destroy(collision.gameObject);
                score += 100;
            } else if (collision.transform.tag=="Boss") {
                OnPerdraVidaBoss.Invoke();
            }
            
        }
        if (collision.transform.tag == "Death" ) {
            Destroy(this.gameObject);
            loadSeen();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag== "laser" || collision.transform.tag == "Exp") {
            Destroy(this.gameObject);
            loadSeen();
        }
    }
    private void tornamal() {
        invul = false;

    }

    private void Comprovar() {
        
        int NewRot = (int)Mathf.Round(this.transform.rotation.eulerAngles.z);
        if (NewRot != OldRot)
        {
            mal = true;
            this.GetComponent<SpriteRenderer>().color = Color.blue;
        }
        else {
            mal = false;
            this.GetComponent<SpriteRenderer>().color = Color.white;
        }
        this.OldRot = NewRot;

    }
    public void loadSeen()
    {
        SceneManager.LoadScene("End");
    }
}
