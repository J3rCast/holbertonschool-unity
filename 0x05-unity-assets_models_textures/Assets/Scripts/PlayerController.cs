using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 6f;
	public float jumpforce = 200f;
	public Rigidbody rb;
	public bool isOnGround = true;

	void Start()
	{
		isOnGround = true;
	}
    // Update is called once per frame
    void Update()
    {
		var vel = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed;
		vel.y = rb.velocity.y;
		rb.velocity = vel;

		if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
		{
			rb.AddForce(Vector3.up * jumpforce);
			isOnGround = false;
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("Ground"))
		{
			isOnGround = true;
		}
	}
}
