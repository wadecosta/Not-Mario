using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	
        
    }

    void OnCollisionEnter(Collision collision)
    {
	    Coin.coin++;
	    Debug.Log(Coin.coin.ToString());
	    Destroy(this.gameObject);
    }
}
