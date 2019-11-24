using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour {

    public float hiz;
    public float mesafe;
    private bool sagaHareket = true;
    public Transform yerTespiti;

    void Update()
    {
        transform.Translate(Vector2.right * hiz * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(yerTespiti.position, Vector2.down, mesafe);
        if(groundInfo.collider== false)
        {
            if (sagaHareket == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                sagaHareket = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                sagaHareket = true;
            }
        }
    }
}
