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
    }

    public Node BuildTreeRecursive(List<Node> contentNodes, Node parent)
    {
    	if(contentNodes[0].isLeaf)
    	{
    		// assign yes node to winstate
    		// assign no node to call question prompt method
    		// return -1? something to move back up a level
       	}
    	else
    	{
    		parent->yes = BuildTreeRecursive(contentNodes, parent->yes);
    		parent->no = BuildTreeRecursive(contentNodes, parent->no);
    	}
    }
}
