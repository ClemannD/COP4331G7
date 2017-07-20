﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUp : MonoBehaviour 
{
	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.name == "Player")
		{
			other.gameObject.GetComponent<KeyManager> ().PickupKey ();
			gameObject.SetActive (false);
		}
	}
}
