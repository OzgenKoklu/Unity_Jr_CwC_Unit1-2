using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset1 = new Vector3(0, 6.5f, -9);
    private Vector3 offset2 = new Vector3(0, 4.2f, 3.18f);
    private bool CameraPos = false;
    private bool buttonPressed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        buttonPressed = Input.GetButtonDown("Jump");
        if (buttonPressed == true)
        {
            CameraPos = !CameraPos;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(CameraPos == false)
        {
            transform.position = player.transform.position + offset1;
            transform.rotation = Quaternion.Euler(20, 0, 0);
         
        }else if(CameraPos == true)
        {
            transform.position = player.transform.position + offset2;
            transform.rotation = player.transform.rotation;
        }
        //karakter pozisyonuna bir offset verip transformuna eþitliyoruz
       
    }
}
