using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingScript : MonoBehaviour
{
    public int buildCost;

    public int goldIncrease;
    public int scienceIncrease;
    public int funIncrease;
    public int capacityIncrease;
    private int BuildingCheck=0;
    

    public float timeBtwIncreases;
    private float nextIncreaseTime=0.0f;

    private GameManagerScript gm;

    private void Start(){
        gm = FindObjectOfType<GameManagerScript>();
        gm.capacity += capacityIncrease;
        
    }

    private void Update()
    {

        if(Time.time > nextIncreaseTime){
            nextIncreaseTime = Time.time + timeBtwIncreases;
            gm.gold += goldIncrease;
            gm.science += scienceIncrease;
            gm.fun += funIncrease;
            
        }   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        BuildingCheck++;
        if(BuildingCheck<=5){

        if (gm.capacity <= 0)
        {
            Debug.Log("Max capacity");
            
        }
        
        else if (gm.capacity > 0)
        {
            
            gm.capacity--;
            Debug.Log("Capacity Left");
            gm.students++;
            Destroy(collision.gameObject);
        }
        }
       
    }
}

    
    
   
