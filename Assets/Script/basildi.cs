using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basildi : MonoBehaviour {

    public bool basildimi;
    Rigidbody2D y_aktiflik;
    karakter k;
	void Start () {
        y_aktiflik = GetComponent<Rigidbody2D>();
	}	
	void Update () {

        if (basildimi == true)
        {
            y_aktiflik.constraints = RigidbodyConstraints2D.FreezePositionX;
        }		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        basildimi = true;
    }
}
