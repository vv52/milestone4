using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public QuestionTree questionTree;

    void Awake()
    {
        questionTree = new QuestionTree();
        questionTree.SetupTree();
    }

    public string ReturnQuestion()
    {
        string temp;
        temp = questionTree.ReturnContent();
        return temp;
    }

    public void Yes()
    {
        questionTree.UpdateYes();
    }

    public void No()
    {
        questionTree.UpdateNo();
    }
}
