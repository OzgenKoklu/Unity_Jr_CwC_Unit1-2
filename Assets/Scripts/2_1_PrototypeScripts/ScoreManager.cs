using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public int lives = 5;
    public int score = 0;


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
        ScoreDisplay();
    }

    public void ScoreDisplay()
    {
        if(lives > 0)
        {
            Debug.Log("Player Lives: " + lives + " Player Score: " + score);
        }else
        {
            Debug.Log("Game Over");
        }
        
    }
}
