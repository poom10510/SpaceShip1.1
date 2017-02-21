using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawShipController : MonoBehaviour {

    public GameObject myShip;
    private GameObject playerShip;
    // Use this for initialization
    void Start()
    {
        playerShip=Instantiate(myShip, this.gameObject.transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Destroy(playerShip);
            playerShip= Instantiate(myShip, this.gameObject.transform.position, Quaternion.identity);
        }
    }

}