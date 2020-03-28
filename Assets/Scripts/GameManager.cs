using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public QuestionTree questionTree;
    public InputField userInput;
    string newAnimal;
    string newQuestion;

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

    // TODO: write new method to call QuestionTree's method
    //       that adds newAnimal and newQuestion to tree

}
