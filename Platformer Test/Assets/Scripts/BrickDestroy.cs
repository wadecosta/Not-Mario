using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BrickDestroy : MonoBehaviour
{
    //public int score = 0;
    //TextMeshProUGUI score_text;

    // Start is called before the first frame update
    void Start()
    {
	    //TextMeshProUGUI score_text = GetComponent<TextMeshProUGUI>();
	    //score_text.SetText("000000");
        
    }

    // Update is called once per frame
    void Update()
    {
	    //TextMeshProUGUI score_text = GetComponent<TextMeshProUGUI>();
	    //score_text.SetText(score.ToString());
        
    }

    void OnCollisionEnter(Collision collision)
    {
	    Score.score++;
	    Debug.Log(Score.score.ToString());
	    Destroy(this.gameObject);
    }
}
