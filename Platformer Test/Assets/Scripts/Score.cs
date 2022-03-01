using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static TextMeshProUGUI score_text;

    // Start is called before the first frame update
    void Start()
    {
	    TextMeshProUGUI score_text = GetComponent<TextMeshProUGUI>();
	    score_text.SetText("000000");
	    //Debug.Log("LET's GO");
        
    }

    // Update is called once per frame
    void Update()
    {
	    TextMeshProUGUI score_text = GetComponent<TextMeshProUGUI>();
	    score_text.SetText(score.ToString());
	    //Debug.Log(score.ToString());
    }
}
