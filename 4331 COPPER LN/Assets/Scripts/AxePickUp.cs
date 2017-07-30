﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxePickUp : MonoBehaviour 
{
	public bool isActive;


	void Start ()
	{
		if(!isActive)
		{
			this.gameObject.SetActive (false);
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.name == "Player")
		{
			other.gameObject.GetComponent<ItemManager> ().PickupAxe ();
			gameObject.SetActive (false);
		}
	}
}