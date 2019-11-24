using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bolum_sistemi : MonoBehaviour {

	// Use this for initialization
	void Start () {
        kilit_sistemi();
	}

    public Button[] butonlar;
	// Update is called once per frame
	public void bolum_ac(string bolum_ismi)
    {
        Application.LoadLevel(bolum_ismi);

    }
    public void kilit_sistemi()
    {
        int bolums = PlayerPrefs.GetInt("bolum");
        for (int i = 0; i < butonlar.Length; i++)
        {
            if (bolums+1>=int.Parse(butonlar[i].name))
            {
                butonlar[i].interactable = true;
            }
            else
            {
                butonlar[i].interactable = false;
            }
        }
    }
}
