using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public GameObject animal;
    public GameObject player;
    private int lives = 3;
    private int score = 0;


    // Start is called before the first frame update
    private void Awake()
    {
        Debug.Log("Player Lives: " + lives + " Player Score: " + score);
    }
    void Start()
    {
        
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
