using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Node.cs;
using File;

public class Tree
{
    Node _root;
    string[] questions = File.ReadAllLines(@"\gameInit.txt", Encoding.UTF8);
}
