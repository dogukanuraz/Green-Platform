using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elektrik : MonoBehaviour {
    float zaman = 3f;
	// Use this for initialization
	void Start () {
        gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        
        zaman -= Time.deltaTime;

        if (zaman <= 0)
        {
            gameObject.SetActive(false);
            zaman = 3f;
        }

        zaman += Time.deltaTime;

        if (zaman >= 6)
        {
            gameObject.SetActive(true);
            zaman = 3f;  
        }

        
    }
}
