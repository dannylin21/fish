﻿using UnityEngine;
using System.Collections;

public class fishController : MonoBehaviour {

	public float velocity = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position -= Vector3.left * velocity * Time.deltaTime;
	}
}
