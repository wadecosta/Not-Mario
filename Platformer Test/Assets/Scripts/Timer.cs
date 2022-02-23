using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float totalTime = 301;

    TextMeshProUGUI timer_text;

    // Start is called before the first frame update
    void Start()
    {
	    TextMeshProUGUI timer_text = GetComponent<TextMeshProUGUI>();
	    timer_text.SetText("Time: 000");

    }

    // Update is called once per frame
    void Update()
    {
	    TextMeshProUGUI timer_text = GetComponent<TextMeshProUGUI>();
	    totalTime -= Time.deltaTime;

	    if(totalTime > 0)
	    {
		    timer_text.SetText($"Time: {Math.Floor(totalTime)}");

		    //Debug.Log($"time is {Math.Floor(totalTime)}");

	    }
        
    }
}
