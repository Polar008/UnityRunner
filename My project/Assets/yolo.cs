using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yolo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion q = this.transform.rotation;
        q.z = (q.z + 10) % 360; 
        this.transform.rotation = q;
    }
}
