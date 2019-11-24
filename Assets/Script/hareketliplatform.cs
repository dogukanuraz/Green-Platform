using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketliplatform : MonoBehaviour {
    [SerializeField]
    private Vector3 velocity;

    private bool hareket;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            hareket = true;
            collision.collider.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.collider.transform.SetParent(null);
        hareket = false;
    }

    private void FixedUpdate()
    {
        if (hareket)
        {
            transform.position += (velocity * Time.deltaTime);
        }
    }
}
