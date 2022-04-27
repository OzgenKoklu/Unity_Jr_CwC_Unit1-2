using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float boundary = 30;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > boundary || transform.position.z < -boundary || transform.position.x > boundary || transform.position.x < -boundary)
        {
            Destroy(gameObject);  
        }

    }
}
