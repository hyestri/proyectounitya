﻿using UnityEngine;
using System.Collections;

public class cookie : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		gameObject.SetActive(false);
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
