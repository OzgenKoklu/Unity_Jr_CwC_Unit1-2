using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpinner : MonoBehaviour
{
    private float propellerTurnSpeed = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back, Time.deltaTime * propellerTurnSpeed);
    }
}
