using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyComp : MonoBehaviour
{
    private GameObject player;
    public float spd;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        this.transform.position= Vector3.MoveTowards(transform.position, player.transform.position,spd*Time.deltaTime);
        /*if (player.transform.position.x > this.transform.position.x)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector3(10, this.GetComponent<Rigidbody2D>().velocity.y, 0);
            this.GetComponent<SpriteRenderer>().flipX = false;
        } else if () { 
        
        }
        else {
            this.GetComponent<Rigidbody2D>().velocity = new Vector3(-10, this.GetComponent<Rigidbody2D>().velocity.y, 0);
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (player.transform.position.y > this.transform.position.y)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector3(this.GetComponent<Rigidbody2D>().velocity.x, 10, 0);
        }
        else
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector3(this.GetComponent<Rigidbody2D>().velocity.x, -10, 0);
        }*/
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Death") {
            Destroy(this.gameObject);
        }
    }
}
