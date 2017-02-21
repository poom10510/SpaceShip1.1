using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour {
    public Material myOtherMaterial;
    private int num = 3;
	public GameObject myBullet;
    public float shotDelay = 0.2f;
    public float shotAt;
	// Use this for initialization
	void Start () {
        shotAt = 0;

    }
	
	// Update is called once per frame
	void Update () {

		if (Input.GetAxis("Horizontal") != 0 ) {
			this.gameObject.transform.Translate (Input.GetAxis ("Horizontal") * Vector3.right * Time.deltaTime *5f);
            if (this.gameObject.transform.position.x < -7f)
            {
                Vector3 tempVector = transform.position;
                tempVector.x = 7.0f;
                transform.position = tempVector;
            }
            else if (this.gameObject.transform.position.x > 7f)
            {
                Vector3 tempVector = transform.position;
                tempVector.x = -7.0f;
                transform.position = tempVector;
            }
        }

		if (Input.GetKey(KeyCode.Space)) {
            if (Time.time - shotAt < shotDelay) return;
            shotAt = Time.time;
            Instantiate (myBullet,this.gameObject.transform.position,Quaternion.identity);
		}
		
	}

    void OnTriggerEnter(Collider other)
    {
        num--;
        //GetComponent<Renderer>().material = myOtherMaterial;
        if (num == 2)
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (num == 1)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            Destroy(this.gameObject);
        }
        //GetComponent<Renderer>().material.color = Color.cyan;
        //Destroy (other.gameObject);
        //Destroy(this.gameObject);
    }
}
