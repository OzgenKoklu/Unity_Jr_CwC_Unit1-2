using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoControl : MonoBehaviour
{
    private float speed = 25.0f;
    private float turnSpeed = 15.0f;
    private float pTwoHorizontalInput;
    private float pTwoVerticalInput;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        //oyuncu inputu alan kod
        pTwoVerticalInput = Input.GetAxis("PlayerTwoVertical");
        pTwoHorizontalInput = Input.GetAxis("PlayerTwoHorizontal");
        //aracýn ileri geri gitmesini saðlayan kod
        transform.Translate(Vector3.forward * Time.deltaTime * speed * pTwoVerticalInput);
        // aracýn ileri geri hareket etmesine göre dönüþ yapýp yapmayacaðýný belirleyen kod
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
