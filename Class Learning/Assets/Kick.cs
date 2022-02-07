using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour
{
    public float kickDist;
    public float kickForce;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") == true)
        {
            Debug.DrawRay(transform.position, transform.forward * kickDist, Color.black, 1.5f); //Draw interaction ray from camera
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, kickDist) == true) //raycast in forward direction from camera position
            {
                Vector3 dir = new Vector3(transform.forward.x, 0, transform.forward.z); //Get direction player is facing
                Debug.DrawRay(transform.position, dir * 3, Color.red, 1.5f); //Draw kick trajectory

                if(hit.collider.tag == "Ball") //is the thing we hit tagged as 'Ball'
                {
                    if(hit.collider.TryGetComponent(out Rigidbody rb) == true) //try to find a rigidbody on the ball
                    {
                        rb.AddForce(dir * kickForce, ForceMode.Impulse); //add an instant force to the ball
                    }
                }
            }
        } 
    }
}
