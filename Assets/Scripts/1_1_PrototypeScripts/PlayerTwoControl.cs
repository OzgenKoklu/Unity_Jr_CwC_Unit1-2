using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoControl : MonoBehaviour
{
    //private float speed = 25.0f;
    private float horsePower = 150000;
    private float turnSpeed = 15.0f;
    private float pTwoHorizontalInput;
    private float pTwoVerticalInput;
    private Rigidbody _carRb;
   
    private void Awake()
    {
        _carRb = GetComponent<Rigidbody>();
   
    }

    void FixedUpdate()
    {
        //oyuncu inputu alan kod
        pTwoVerticalInput = Input.GetAxis("PlayerTwoVertical");
        pTwoHorizontalInput = Input.GetAxis("PlayerTwoHorizontal");
        _carRb.AddRelativeForce(Vector3.forward * horsePower * pTwoVerticalInput);
        
        if (pTwoVerticalInput > 0f)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * pTwoHorizontalInput);
        }
        else if (pTwoVerticalInput < 0f)
        {
            transform.Rotate(Vector3.up, -1 * Time.deltaTime * turnSpeed * pTwoHorizontalInput);
        }
    }
}
