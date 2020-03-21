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

    public Node BuildTree(List<Node> contentNodes)
    {
    	_root = contentNodes[0];
    	contentNodes.RemoveAt(0);

    	_root->yes = BuildTreeRecursive(contentNodes, _root->yes);
    	_root->no = BuildTreeRecursive(contentNodes, _root->no);

    	return _root;
    }

    public Node BuildTreeRecursive(List<Node> contentNodes, Node current)
    {
    	current = contentNodes[0];
    	contentNodes.RemoveAt(0);

    	if(contentNodes[0].isLeaf)
    	{
    		current->yes = new Node();
    		current->yes.question = "I win! Try again...";

    		current->no = new Node();
    		current->no.question = "I lose... What is the answer?";

    		// use isLeaf to call either Win(); or Prompt();
    		// upon reaching this point from the game itself
       	}
    	else
    	{
    		current->yes = BuildTreeRecursive(contentNodes, current->yes);
    		current->no = BuildTreeRecursive(contentNodes, current->no);
    	}

    	return current;
    }
}
