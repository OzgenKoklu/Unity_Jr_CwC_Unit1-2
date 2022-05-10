using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{

    // private float speed = 25.0f;
    private float horsePower = 150000;
    private float turnSpeed = 15.0f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody _carRb;


    private void Awake()
    {
        _carRb = GetComponent<Rigidbody>();
    

    }
    void FixedUpdate()
    {
        //oyuncu inputu alan kod
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        _carRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
       
        if (verticalInput > 0f)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        }
        else if (verticalInput < 0f)
        {
            transform.Rotate(Vector3.up, -1 * Time.deltaTime * turnSpeed * horizontalInput);
        }
    }
}
