using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX2 : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timePassed = 1.5f;

    // Update is called once per frame
    void Update()
    {
        if(timePassed < 1.6f) { 
        timePassed += Time.deltaTime;
        }

        if (timePassed > 1.5f) { 
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timePassed = 0;
            }  
        }
    }
}
