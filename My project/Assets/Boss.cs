using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private GameObject player;
    public PlayCont playCont;
    public int vidaTotal;
    public int vidaActual;
    public GameObject[] enemic;
    void Start()
    {
        InvokeRepeating("spawn", 0f, 3f);
        Invoke("WarnMissil", 4f);
        player = GameObject.Find("Player");
        playCont.OnPerdraVidaBoss += PerdreVida;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.transform.position.x + "    " + this.transform.GetChild(1).transform.position.x);
        if (player.transform.position.x > this.transform.GetChild(1).transform.position.x)
        {
            transform.GetChild(1).GetComponent<Rigidbody2D>().velocity = new Vector3(5, transform.GetChild(1).GetComponent<Rigidbody2D>().velocity.y, 0);
            //this.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (this.transform.GetChild(1).transform.position.x > 0)
        {
            transform.GetChild(1).GetComponent<Rigidbody2D>().velocity = new Vector3(-5, transform.GetChild(1).GetComponent<Rigidbody2D>().velocity.y, 0);
            //this.GetComponent<SpriteRenderer>().flipX = true;
        }
        //Debug.Log(player.transform.position.x + "    " + this.transform.GetChild(0).transform.position.x);
        if (player.transform.position.x > this.transform.GetChild(0).transform.position.x)
        {
            transform.GetChild(0).GetComponent<Rigidbody2D>().velocity = new Vector3(5, transform.GetChild(0).GetComponent<Rigidbody2D>().velocity.y, 0);
            //this.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (this.transform.GetChild(0).transform.position.x > -10)
        {
            transform.GetChild(0).GetComponent<Rigidbody2D>().velocity = new Vector3(-5, transform.GetChild(0).GetComponent<Rigidbody2D>().velocity.y, 0);
            //this.GetComponent<SpriteRenderer>().flipX = true;
        }
    }
    public void spawn() {
        GameObject Clone = Instantiate(enemic[0], new Vector3(this.transform.position.x, this.transform.position.y - 3, 0), this.transform.rotation);
    }
    public void WarnMissil() {
        GameObject Clone = Instantiate(enemic[2], new Vector3(this.transform.position.x, this.transform.position.y - 25, 0), this.transform.rotation);
        Clone.transform.parent = transform;
        Invoke("Missil", 2f);
    }
    public void Missil(){
        Destroy(this.transform.GetChild(2).gameObject);
        GameObject Clone = Instantiate(enemic[1], new Vector3(this.transform.position.x, this.transform.position.y - 3, 0), this.transform.rotation);
        Invoke("WarnMissil", Random.Range(4f, 10f));
    }
    public void PerdreVida() {
        vidaActual--;
        if (vidaActual == 0) {
            playCont.score += 1000;
            Invoke("ImBack", 3f);
            this.gameObject.SetActive(false);
            
        }
    }
    public void ImBack() {
        this.gameObject.SetActive(true);
        vidaTotal += 5;
        vidaActual = vidaTotal;
    }
}
