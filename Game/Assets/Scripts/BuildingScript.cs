using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BuildingScript : MonoBehaviour
{
    public int buildCost;

    public int goldIncrease;
    public float timeBtwIncreases;
    private float nextIncreaseTime=0.0f;

    private GameManagerScript gm;

    private void Start(){
        gm = FindObjectOfType<GameManagerScript>();
    }

    private void Update()
    {
        if(Time.time > nextIncreaseTime){
            nextIncreaseTime = Time.time + timeBtwIncreases;
            gm.gold += goldIncrease;
        }   
    }
    
    
   
}
