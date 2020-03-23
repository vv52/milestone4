using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    public Text QuestionText;
    public GameManager Manager;

    void Awake()
	{
    	QuestionText.text = Manager.ReturnQuestion();
	}
}
