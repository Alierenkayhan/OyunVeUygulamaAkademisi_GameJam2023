using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public int scienceDecrease;

    public float timeBtwDecreases;
    private float nextDecreaseTime=0.0f;

    private GameManagerScript gm;
    // Start is called before the first frame update

    void Start()
    {
        gm = FindObjectOfType<GameManagerScript>();
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextDecreaseTime){
            nextDecreaseTime = Time.time + timeBtwDecreases;
            gm.science -= scienceDecrease;
        }   
        
    }
}
