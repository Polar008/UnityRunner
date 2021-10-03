using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -2, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag== "Death") {
            Destroy(this.gameObject);
        }
    }
}
