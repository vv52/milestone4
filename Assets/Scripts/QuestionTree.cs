using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;

public class QuestionTree
{
    Node _root;
    List<Node> questionData;
    Node current;
    Node saveLeaf;

    public List<Node> BuildList()
    {
    	List<Node> nodes = new List<Node>();
    	string[] questions = System.IO.File.ReadAllLines("Assets/gameInit.txt");
        foreach (var question in questions)
        {
            Node node = new Node();
            node.question = question;

            if(question.Length > 0 && question[0] == '*')
            {
                node.question = question.Substring(1);
                node.isLeaf = true;
            }
            nodes.Add(node);
        }
        return nodes;
    }

    public Node BuildTree(List<Node> contentNodes)
    {
    	_root = contentNodes[0];
    	contentNodes.RemoveAt(0);

    	_root.yes = BuildTreeRecursive(contentNodes, _root.yes);
    	_root.no = BuildTreeRecursive(contentNodes, _root.no);

    	return _root;
    }

    public Node BuildTreeRecursive(List<Node> contentNodes, Node current)
    {
    	current = contentNodes[0];
    	contentNodes.RemoveAt(0);

        if (contentNodes.Count < 1)
        {
            return current;
        }
        else if(current.isLeaf)
    	{
    		current.yes = new Node();
    		current.yes.question = "I win! Try again...";

    		current.no = new Node();
    		current.no.question = "I lose... What is the answer?";
       	}
    	else
    	{
    		current.yes = BuildTreeRecursive(contentNodes, current.yes);
    		current.no = BuildTreeRecursive(contentNodes, current.no);
    	}

    	return current;
    }

    public void SetupTree()
    {
        questionData = new List<Node>();
        questionData = BuildList();
        BuildTree(questionData);
        current = _root;
    }

    public string ReturnContent()
    {
        return current.question;
    }

    public void UpdateYes()
    {
        current = current.yes;
    }

    public void UpdateNo()
    {
        saveLeaf = current;
        current = current.no;
    }

    public void AddAnimal(string animalName, string animalQuestion)
    {
        current.question = animalQuestion;
        current.isLeaf = false;
        current.no = new Node();
        current.no.isLeaf = true;
        current.no.question = saveLeaf.question;
        current.yes = new Node();
        current.yes.isLeaf = true;
        current.yes.question = "is it a " + animalName + "?";
    }

    public void WriteToFile()
    {
        Debug.Log(current.question);
        Debug.Log(current.yes.question);
        Debug.Log(current.no.question);

        string[] treeContent = RebuildArray();
        System.IO.File.WriteAllLines("Assets/gameInitTEST.txt", treeContent);
    }

    public string[] RebuildArray()
    {
        List<string> updatedQuestions = new List<string>();
        updatedQuestions.Add(_root.question);

        RebuildArrayRecursive(updatedQuestions, _root.yes);
        RebuildArrayRecursive(updatedQuestions, _root.no);

        string[] treeContent = updatedQuestions.ToArray();
        return treeContent;
    }

    public List<string> RebuildArrayRecursive(List<string> updatedQuestions, Node current)
    {
        if(current.isLeaf)
        {
            updatedQuestions.Add("*" + current.question);
        }
        else
        {
            updatedQuestions.Add(current.question);
            RebuildArrayRecursive(updatedQuestions, current.yes);
            RebuildArrayRecursive(updatedQuestions, current.no);
        }
        return updatedQuestions;
    }
}
