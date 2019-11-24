using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {


    GameObject karakter;
    public float yukseklik;
    public float mesafe;

	void Start () {
       karakter = GameObject.FindGameObjectWithTag("Player");

	}
	
	void Update () {
       
           transform.position = new Vector3(karakter.transform.position.x + mesafe, karakter.transform.position.y + yukseklik, transform.position.z);
        
        
    }
}
