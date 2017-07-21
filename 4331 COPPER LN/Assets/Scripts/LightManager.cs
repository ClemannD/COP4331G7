﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour 
{
	private Light lightSource;

	public float unLit = 30;
	public float oneQtrLit = 50;
	public float halfLit = 70;
	public float threeQtrLit = 90;
	public float fullLit = 110;


	// Use this for initialization
	void Start () 
	{
		lightSource = GetComponent<Light> ();
		lightSource.spotAngle = unLit;
	}


	// Sets the angle(radius) of light
	public void SetToEmpty()
	{
		lightSource.spotAngle = unLit;
	}

	public void SetToOneQtr()
	{
		lightSource.spotAngle = oneQtrLit;
	}
		
	public void SetToHalf()
	{
		lightSource.spotAngle = halfLit;
	}

	public void SetToThreeQtr()
	{
		lightSource.spotAngle = threeQtrLit;
	}

	public void SetToFull()
	{
		lightSource.spotAngle = fullLit;
	}
		
}