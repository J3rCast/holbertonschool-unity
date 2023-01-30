using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject player;
	public Vector3 offset;
	public float turnSpeed = 3.0f;

    // Update is called once per frame
    void Update()
    {
		float h = Input.GetAxis("Mouse X") * turnSpeed;
		player.transform.Rotate(0, h, 0);

		offset = Quaternion.AngleAxis (Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
        transform.position = player.transform.position + offset;
		transform.LookAt(player.transform.position);
    }
}
