﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopScript : MonoBehaviour {
    public string msgPlayer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        PlayerScript theotherObjectScript = other.gameObject.GetComponent<PlayerScript>();
        theotherObjectScript.status = msgPlayer;
    }

    private void OnTriggerExit(Collider other)
    {

        PlayerScript theotherObjectScript = other.gameObject.GetComponent<PlayerScript>();
        theotherObjectScript.status = "";
    }

}
