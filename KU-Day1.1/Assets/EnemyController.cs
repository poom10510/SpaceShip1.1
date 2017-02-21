using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    private int num = 3;
    public AudioClip myExplosion;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.down * Time.deltaTime * 10f);
        if (this.gameObject.transform.position.y <= -10f)
        {
            Destroy(this.gameObject);
        }
    }

	void OnTriggerEnter (Collider other) {
        //Destroy (other.gameObject);
        //Destroy(this.gameObject);
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
    }
}
