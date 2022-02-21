using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthFirstSearch : MonoBehaviour
{
    public Node rootNode;
    public Node target;

    private void Start()
    {
        int stepCount = DFS(target);
        if(stepCount > -1)
        {
            Debug.Log(target.name + " was found in " + stepCount + " steps.");
        }
        else
        {
            Debug.Log(target.name + " was not found.");
        }
    }

    public int DFS(Node targetNode)
    {
        Stack stack = new Stack(); //stack the nodes, the last one stacked is the next one visted
        List<Node> visitedNodes = new List<Node>(); //tracks the visted nodes
        visitedNodes.Add(rootNode); //visit root node
        stack.Push(rootNode); //push root node to the stack

        while (stack.Count > 0) //while the stack is not empty
        { 
            Node node = (Node)stack.Pop(); //get the last stacked node
            Debug.Log("Checking: " + node.name); 
            foreach (Node child in node.childern) //loop through the childern of the node
            {
                //if the child has not been visited
                if(visitedNodes.Contains(child) == false)
                {
                    Debug.Log("Checking child " + child.name + " of node " + node.name);
                    if(child == targetNode) //target node found
                    {
                        Debug.Log("Target " + child.name + " found");
                        return visitedNodes.Count; //return number of visited nodes
                    }
                    visitedNodes.Add(child); //visit the node
                    stack.Push(child); //add node to stack
                }
            }
        }
        return -1;
    }
}
