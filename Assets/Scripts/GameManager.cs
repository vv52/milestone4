using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public QuestionTree questionTree;
    public InputField userInput;
    public Text questionText;
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

    public void RegAnimal()
    {
        newAnimal = userInput.text;
        questionText.text = "what is a question I can ask to guess that animal?";
    }

    public void RegQuestion()
    {
        newQuestion = userInput.text;
        AddNewAnimal();
    }

    public void AddNewAnimal()
    {
        questionTree.AddAnimal(newAnimal, newQuestion);
        questionTree.WriteToFile();
    }
}
