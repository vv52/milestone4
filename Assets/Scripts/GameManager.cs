using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public QuestionTree questionTree;

    // Start is called before the first frame update
    void Start()
    {
        questionTree.SetupTree();
    }
}
