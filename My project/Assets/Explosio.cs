using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Die", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void die() {
        Destroy(this.gameObject);
    }
}
