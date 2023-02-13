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

	void FixedUpdate()
    {
		Vector3 movement = new Vector3( Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
		if (Input.GetKey("w"))
		{
			transform.Translate(movement * speed * Time.deltaTime, Space.Self);
		}
		if (Input.GetKey("a"))
		{
			transform.Translate(movement * speed * Time.deltaTime, Space.Self);
		}
		if (Input.GetKey("d"))
		{
			transform.Translate(movement * speed * Time.deltaTime, Space.Self);
		}
		if (Input.GetKey("s"))
		{
			transform.Translate(movement * speed * Time.deltaTime, Space.Self);
		}
	}
    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
		{
			rb.AddForce(Vector3.up * jumpforce);
			isOnGround = false;
		}
		
		if (gameObject.transform.position.y <= -20)
		{
			gameObject.transform.position = new Vector3(0, 15, 0);
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
