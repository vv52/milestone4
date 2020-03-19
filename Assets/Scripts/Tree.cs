using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Node.cs;

public class Tree
{
    Node _root;

    vector<string> questions;

    questions.push_back("does it walk on four legs");
    questions.push_back("does it bark?");
    questions.push_back("*is it a dog?");
    questions.push_back("does it slither?");
    questions.push_back("*is it a snake?");

    void ReadFromFile()
    {
    	Node current;
    	current = _root;

    	while (int i = 0; i < questions.size(); i++)
    	{
    		current.question = questions[i];
    		
    	}
    }
}
