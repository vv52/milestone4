using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
	public Node yes { get; set; }
    public Node no { get; set; }
    public string question { get; set; }
    public bool isLeaf { get; set; }
}
