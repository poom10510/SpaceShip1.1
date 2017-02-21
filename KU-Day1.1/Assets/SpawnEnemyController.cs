using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyController : MonoBehaviour {

	public GameObject myEnemy;
    public GameObject myEnemy1;
    public GameObject myEnemy2;
    public GameObject myEnemy3;
    public GameObject myEnemy4;
    public GameObject myEnemy5;
    public GameObject myEnemy6;
    public GameObject myEnemy7;
    public GameObject myEnemy8;
    public GameObject myEnemy9;
    public GameObject myEnemy10;
    // Use this for initialization
    void Start () {
		StartCoroutine (SpawnEnemy (1f));
	}
	
	// Update is called once per frame
	void Update () {
		//Instantiate (myEnemy, this.gameObject.transform.position, Quaternion.identity);
	}

	IEnumerator SpawnEnemy(float waitTime) {
        int nume = Random.Range(0, 4);
        for(int i =0;i<= nume; i++)
        {
            int ran = Random.Range(0, 11);
            //Debug.Log(ran);
            switch (ran)
            {
                case 1:
                    Instantiate(myEnemy1, myEnemy1.transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(myEnemy2, myEnemy2.transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(myEnemy3, myEnemy3.transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(myEnemy4, myEnemy4.transform.position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(myEnemy5, myEnemy5.transform.position, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(myEnemy6, myEnemy6.transform.position, Quaternion.identity);
                    break;
                case 7:
                    Instantiate(myEnemy7, myEnemy7.transform.position, Quaternion.identity);
                    break;
                case 8:
                    Instantiate(myEnemy8, myEnemy8.transform.position, Quaternion.identity);
                    break;
                case 9:
                    Instantiate(myEnemy9, myEnemy9.transform.position, Quaternion.identity);
                    break;
                case 10:
                    Instantiate(myEnemy10, myEnemy10.transform.position, Quaternion.identity);
                    break;
                default:
                    Instantiate(myEnemy, myEnemy.transform.position, Quaternion.identity);
                    break;
            }
        }
        
        //Instantiate (myEnemy, this.gameObject.transform.position, Quaternion.identity);

		yield return new WaitForSeconds(waitTime);
        float wait = Random.Range(0, 2);
        StartCoroutine (SpawnEnemy (wait));
	}
}
