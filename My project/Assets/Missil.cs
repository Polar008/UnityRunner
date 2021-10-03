using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : MonoBehaviour
{
    private GameObject player;
    public GameObject ex;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y - player.transform.position.y < .1f) {
            Instantiate(ex, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), this.transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
