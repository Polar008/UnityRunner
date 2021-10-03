using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("kill",1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void kill()
    {
        Destroy(this.gameObject);
    }
}
