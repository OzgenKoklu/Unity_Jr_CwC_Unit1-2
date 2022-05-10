using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float boundary = 30;
    ScoreManager scoreManager;
    // Start is called before the first frame update
    private void Awake()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckOutofBounds();

    }

    public void CheckOutofBounds()
    {
        if (transform.position.z > boundary || transform.position.z < -boundary || transform.position.x > boundary || transform.position.x < -boundary)
        {
            Destroy(gameObject);

            if(gameObject.tag != "Sammich")
            scoreManager.lives -= 1;
        }
    }
}
