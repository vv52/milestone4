﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterAnimal : MonoBehaviour
{
	public GameManager gameManager;

	public void OnClick()
	{
		gameManager.RegAnimal();
	}
}
