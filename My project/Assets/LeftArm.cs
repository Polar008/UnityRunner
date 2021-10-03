using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArm : MonoBehaviour
{
    public GameObject laser;
    public GameObject war;
    public int vidaTotal;
    public int vidaActual;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shoot", 1f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TrackPlayer()
    {

    }

    public void shoot() {
        GameObject Clone = Instantiate(war, new Vector3(this.transform.position.x, this.transform.position.y - 25, 0), this.transform.rotation);
        Clone.transform.parent = transform;
        Invoke("shootTheLaser",2f);
    }
    public void shootTheLaser()
    {
        Destroy(this.transform.GetChild(0).gameObject);
        GameObject Clone = Instantiate(laser, new Vector3(this.transform.position.x, this.transform.position.y - 25, 0), this.transform.rotation);
        Clone.transform.parent = transform;
    }
    public void PerdreVida()
    {
        vidaActual--;
        if (vidaActual == 0)
        {
            this.gameObject.SetActive(false);
            Invoke("ImBack", 3f);
        }
    }
    public void ImBack()
    {
        this.gameObject.SetActive(false);
        vidaTotal += 5;
        vidaActual = vidaTotal;
    }
}
