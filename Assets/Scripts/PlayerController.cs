﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 10;
	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent <Rigidbody> ();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 force = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (force * speed);
	}
}
