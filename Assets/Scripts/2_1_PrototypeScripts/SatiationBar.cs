using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SatiationBar : MonoBehaviour
{
    [SerializeField]private Image foregroundImage;
    //private float updateSpeedSeconds = 0.5f;
    DetectCollisions detectCollisions; 
    // Start is called before the first frame update
    private void Awake()
    {
       detectCollisions = GetComponentInParent<DetectCollisions>();
        foregroundImage.fillAmount = 0;
    }
   
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foregroundImage.fillAmount = detectCollisions.currentSatiationPct;
    }
}
