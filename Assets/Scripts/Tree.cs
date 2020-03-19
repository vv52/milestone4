using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Node.cs;
using System;
using System.Text;

public class Tree
{
    Node _root;

    public List<Node> BuildList()
    {
    	List<Node> nodes = new List<Node>();
    	string[] questions = System.IO.File.ReadAllLines("gameInit.txt");
        foreach (var question in questions)
        {
            Node node = new Node();
            node.question = question;

            if(question.Length > 0 && question[0] == '*')
            {
                node.question = question.Substring(1);
                node.isLeaf = true;
            }
            nodes.push_back(node);
        }
        return nodes;
    }

    public 
}
