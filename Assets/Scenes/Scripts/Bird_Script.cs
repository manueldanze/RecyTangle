using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Script : MonoBehaviour
{

    public Rigidbody2D birdRigidBody;

    public float flapStrength;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // old input system maybe change to new one
        {
            birdRigidBody.velocity = Vector2.up * flapStrength; // Vector2.up is a shortcut for Vector(0,1)
        }

        
    }
}
