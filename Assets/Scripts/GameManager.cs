using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public QuestionTree questionTree;

    // Start is called before the first frame update
    void Start()
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
}
