using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private int currentSatiation;
    [SerializeField] int animalSatiated;
    public float currentSatiationPct;

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
        hungerManagement();
        currentSatiationPct = (float)currentSatiation / (float)animalSatiated;
        Debug.Log(currentSatiationPct);
    }

    private void hungerManagement()
    {


        if(currentSatiation >= animalSatiated)
        {
            Destroy(gameObject);
            scoreManager.score += 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sammich")
        {
          Destroy(other.gameObject);
            currentSatiation += 1;
        }
        
        if (other.tag == "Player")
        {
            scoreManager.lives -= 1;
        }
            
    }
}
