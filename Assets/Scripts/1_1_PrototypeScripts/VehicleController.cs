using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    //private variables
    private float speed = 25.0f;
    private float turnSpeed = 15.0f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    private void Start()
    {
     
    }
    // Update is called once per frame
    void Update()
    {
        //oyuncu inputu alan kod
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        //aracýn ileri geri gitmesini saðlayan kod
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput); 
        // aracýn ileri geri hareket etmesine göre dönüþ yapýp yapmayacaðýný belirleyen kod
        if (verticalInput > 0f) { 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        } else if (verticalInput < 0f)
        {
            transform.Rotate(Vector3.up,-1 *Time.deltaTime * turnSpeed * horizontalInput);
        }
    }
}
