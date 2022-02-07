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

        stack.Push(rootNode); //push root node to the stack

        while (stack.Count > 0)
        { 
            Node node = (Node)stack.Pop(); //get the last stacked node
            visitedNodes.Add(node); //visit the node

            foreach (Node child in node.childern) //loop through the childern of the node
            {
                if(visitedNodes.Contains(child) == false && stack.Contains(child) == false)
                {
                    if(child == targetNode)
                    {
                        return visitedNodes.Count; //retunr number of visited nodes
                    }
                    stack.Push(child);
                }
            }
        }
        return -1;
    }
}
