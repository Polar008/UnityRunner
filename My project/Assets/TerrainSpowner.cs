using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpowner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] terra;
    void Start()
    {
        InvokeRepeating("spawn", 1f, 3f);
        InvokeRepeating("spawnEne", 1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawn() {
         
        GameObject Clone = Instantiate(terra[0], new Vector3(Random.Range(0, 10), 5, 0), this.transform.rotation);
        Clone.transform.localScale = new Vector3(Random.Range(20, 35), 1, 1);
    }
    private void spawnEne()
    {
        GameObject Clone = Instantiate(terra[1], new Vector3(Random.Range(0, 10), 6, 0), this.transform.rotation);
    }
}
