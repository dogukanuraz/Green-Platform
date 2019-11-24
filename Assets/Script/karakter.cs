using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class karakter : MonoBehaviour {

    // Use this for initialization
    public float hiz;
    public float h;
    public float ziplama_gucu;
    Rigidbody2D fizik_karakter;
    public bool yerdemi;
    public static int yildiz_sayisi;
    public int cansayisi;
    public int maxcan;
    public Text yazi;
    Animator animasyon_oynatici;
    float time = 3f;
    public GameObject[] canlar;

	void Start () {
        yildiz_sayisi = 0;
        yildiz_sayisi = PlayerPrefs.GetInt("yildiz");
        fizik_karakter = GetComponent<Rigidbody2D>();
        animasyon_oynatici = GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        yazi.text = yildiz_sayisi.ToString();

		if (Input.GetKeyDown(KeyCode.Space) && yerdemi)
        {
            fizik_karakter.velocity += new Vector2(0, ziplama_gucu);
            yerdemi = false;
        }
        if (transform.position.y < -5f)
        {
            olum();
        }
        if (cansayisi == 0)
        {
            olum();
        }
	}
    void FixedUpdate()
    {
        h = Input.GetAxis("Horizontal");

        transform.position += new Vector3(h * hiz * Time.deltaTime, 0, 0);
        if (h > 0)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        else if (h < 0)
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }
        animasyon_oynatici.SetFloat("hiz", Mathf.Abs(h));
        animasyon_oynatici.SetBool("yerde", yerdemi);

    }
    void olum()
    {
        //PlayerPrefs.SetInt("yildiz", yildiz_sayisi);
        Application.LoadLevel(Application.loadedLevel);

    }
    void canazalma()
    {
        cansayisi--;
        GameObject.Find("can" + cansayisi.ToString()).active = false;
    }
    

    
    void OnTriggerEnter2D(Collider2D coll)
    {
        
        if (coll.gameObject.tag == "su" || coll.gameObject.tag == "elektrik")
        {
            olum();
        }
        if (coll.gameObject.tag == "ates" || coll.gameObject.tag == "ari")
        {
            if (time <= 0)
            {
                canazalma();
                time = 3f;
            }
        }
        else if (coll.gameObject.tag == "can")
        {
            if (cansayisi < maxcan)
            {
                canlar[cansayisi].active = true;
                cansayisi++;
                GameObject.Destroy(coll.gameObject);
            }
        }
        if (coll.gameObject.tag == "kapi")
        {
            
            PlayerPrefs.SetInt("yildiz", yildiz_sayisi);
            PlayerPrefs.SetInt("bolum", Application.loadedLevel);
            SceneManager.LoadScene("2");
        }
        else if (coll.gameObject.tag == "kapi2")
        {
            SceneManager.LoadScene("3");
        }
        else if (coll.gameObject.tag == "kapi3")
        {
            SceneManager.LoadScene("4");
            
        }
        else if (coll.gameObject.tag == "kapi4")
        {
            SceneManager.LoadScene("5");
        }
        else if (coll.gameObject.tag == "kapi5")
        {
            SceneManager.LoadScene("6");
        }
        else if (coll.gameObject.tag == "kapi6")
        {
            SceneManager.LoadScene("7");
        }

    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "ates" || coll.gameObject.tag == "ari")
        {
            if (time <= 0)
            {
                canazalma();
                time = 3f;
            }
        }
    }
}
