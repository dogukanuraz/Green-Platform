using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yildiz : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            karakter.yildiz_sayisi++;
            Debug.Log(karakter.yildiz_sayisi);
            GameObject.Destroy(this.gameObject);

        }
    }
}
