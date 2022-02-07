using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Node[] parents;
    public Node[] childern;

    private void OnDrawGizmos()
    {
        if (childern.Length > 0)
        {
            for (int i = 0; i < childern.Length; i++)
            {
                Debug.DrawLine(transform.position, childern[i].transform.position, Color.black);
            }
        }
    }
}
