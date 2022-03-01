using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{

    public float coin = 0;
    TextMeshProUGUI coin_text;

    // Start is called before the first frame update
    void Start()
    {
	    TextMeshProUGUI coin_text = GetComponent<TextMeshProUGUI>();
	    coin_text.SetText("x00");
        
    }

    // Update is called once per frame
    void Update()
    {
	    TextMeshProUGUI coin_text = GetComponent<TextMeshProUGUI>();
	    coin += Time.deltaTime;

	    if(coin < 100)
	    {
		    coin_text.SetText($"x{Math.Floor(coin)}");
	    }
        
    }
}
