using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnsDos : MonoBehaviour
{
    public GameObject[] terra;
    private bool dreta = true;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 0f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void spawn()
    {
        
        if (dreta)
        {
            GameObject Clone = Instantiate(terra[0], new Vector3(10, 13, 0), this.transform.rotation);
            dreta = false;
        }
        else {
            GameObject Clone = Instantiate(terra[0], new Vector3(-10, 13, 0), this.transform.rotation);
            dreta = true;
        }
        
        //Clone.transform.localScale = new Vector3(Random.Range(20, 35), 1, 1);
    }
}
