using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	public AudioClip myExplosion;
	// Use this for initialization
	void Start () {
        int num = Random.Range(0, 3);
        if (num == 2)
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        else if (num == 1)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        //Debug.Log(num);
    }
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.Translate (Vector3.up * Time.deltaTime * 10f);
		if (this.gameObject.transform.position.y >= 20f) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter (Collider other) {
		Debug.Log ("Aow Hey");
		//Destroy (other.gameObject);
		this.gameObject.GetComponent<AudioSource> ().clip = myExplosion;
		this.gameObject.GetComponent<AudioSource> ().Play ();
		Destroy (this.gameObject);

	}
}
