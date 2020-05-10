﻿using UnityEngine;

public class Move : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
   // void Start()
    //{ }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Add a forward force
       rb.AddForce(0, 0, forwardForce * Time.deltaTime);

       if ( Input.GetKey ("d") )
       {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
       }
       if ( Input.GetKey ("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f){
          FindObjectOfType<Manager>().EndGame();
        }
    }

}
