using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float runForce = 10f;
    public float jumpForce = 20f;
    public float maxRunSpeed = 6f;

    public bool feetInContactWithGround;
    private Rigidbody body;
    private Collider collider;

    // Start is called before the first frame update
    void Start()
    {
	    body = GetComponent<Rigidbody>();
	    collider = GetComponent<Collider>();
        
    }

    // Update is called once per frame
    void Update()
    {
	    float castDistance = collider.bounds.extents.y + 0.1f;
	    feetInContactWithGround = Physics.Raycast(transform.position, Vector3.down, castDistance);

	    float axis = Input.GetAxis("Horizontal");
	    body.AddForce(Vector3.right * axis * runForce, ForceMode.Force);

	    if(feetInContactWithGround && Input.GetKeyDown(KeyCode.Space))
	    {
		    body.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
	    }
	    else if(body.velocity.y > 0f && Input.GetKey(KeyCode.Space))
	    {
		    body.AddForce(Vector3.up * jumpForce, ForceMode.Force);
	    }

	    if(Mathf.Abs(body.velocity.x) > maxRunSpeed)
	    {
		    float newX = maxRunSpeed * Mathf.Sign(body.velocity.x);
		    body.velocity = new Vector3(newX, body.velocity.y, body.velocity.z);
	    }

	    if(axis < 0.1f)
	    {
		    float newX = body.velocity.x * (1f - Time.deltaTime * 5f);
		    body.velocity = new Vector3(newX, body.velocity.y, body.velocity.z);
	    }
        
    }

void OnCollisionEnter(Collision collision)
    {
	    if(collision.gameObject.tag == "Water")
	    {
		    transform.position = new Vector3(14, 3, 0);
	    }
    }
}
