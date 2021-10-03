using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blink : MonoBehaviour
{
    [Range(0f,1f)]
    public float time;
    [Range(0f, 1f)]
    public float alphaOn;
    [Range(0f, 1f)]
    public float alfphaOff;
    bool achus = true;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("blink1", 0, 0.2f);
    }

    // Update is called once per frame
    private void blink1()
    {
        Color c = this.GetComponent<SpriteRenderer>().material.color;
        if (achus)
        {
            c.a = alfphaOff;
        }
        else
        {
            c.a = alphaOn;
        }
        achus = !achus;
        this.GetComponent<SpriteRenderer>().material.color = c;
    }
}
