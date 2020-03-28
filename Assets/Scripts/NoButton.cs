using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoButton : MonoBehaviour
{
    public TextManager textManager;

    void Awake()
    {
        textManager = GameObject.Find("Question").GetComponent<TextManager>();
    }

    public void OnClick()
    {
        textManager.UpdateNo();
    }
}
