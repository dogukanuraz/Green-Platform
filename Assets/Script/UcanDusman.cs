using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UcanDusman : MonoBehaviour {

    private karakter krktr;

    public float hiz;

    //public float menzil;



	// Use this for initialization
	void Start () {
        krktr = FindObjectOfType<karakter>();

	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, krktr.transform.position, hiz * Time.deltaTime);
        
	}
}
