using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterQuestion : MonoBehaviour
{
	public GameManager gameManager;

	public void OnClick()
	{
		gameManager.RegQuestion();
	}
}
