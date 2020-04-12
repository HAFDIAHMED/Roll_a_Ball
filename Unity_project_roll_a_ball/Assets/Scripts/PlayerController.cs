using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    public float speed;
   //Before generating the frame
   /*
   void Update()
    {

    }
    */

    void Start ()
    {
     rb = GetComponent<Rigidbody>();
    }

    //Before performing physics calculation
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal , 0 , moveVertical);
        //rb.AddForce(moveHorizontal , 0 , moveVertical, ForceMode.Impulse);
        rb.AddForce(movement * speed);
    }

    
}
