﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llaveTrans : MonoBehaviour {

	public GameObject door;

	MeshRenderer m;
	// Use this for initialization
	void Start () {
		m = GetComponent<MeshRenderer> ();
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider Other){

		if(Other.gameObject.CompareTag("Player")){
			m.enabled = false;
			door.gameObject.GetComponent<puertaTeletrans>().SetLlave();
		}
	}
}
