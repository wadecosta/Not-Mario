using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public float proximityThreshold = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    Ray ray = new Ray(transform.position, Vector3.down);
	    
	    if (Physics.Raycast(ray, out RaycastHit hitInfo, proximityThreshold))
	    {
		    Debug.DrawRay(transform.position, Vector3.down * proximityThreshold, Color.red);

	    }
	    else
	    {
		    Debug.DrawRay(transform.position, Vector3.down * proximityThreshold, Color.blue);
	    }
        
    }
}
