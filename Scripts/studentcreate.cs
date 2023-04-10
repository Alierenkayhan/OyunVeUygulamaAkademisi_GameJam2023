using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studentcreate : MonoBehaviour
{
    
    [SerializeField] int stundentsnumber = 0;
    public int maxstundentsnumber = 10;
    [SerializeField] float durationbetweenstudentscreation;
    private float nextCreateTime=0.0f;

    public int randNum;

    [SerializeField] GameObject[] student;

    [SerializeField] float studentprefabx;
    [SerializeField] float studentprefaby;

    //private void Start(){
        
    //}


     private void Update()
    {
        randNum = Random.Range(0,4);
        if (stundentsnumber < maxstundentsnumber)
        { 
            if(Time.time > nextCreateTime){
            nextCreateTime = Time.time + durationbetweenstudentscreation;
            Instantiate(student[randNum], new Vector2(studentprefabx, studentprefaby), Quaternion.identity);
            stundentsnumber++;  
        }   
        
        }

       
    }

    
}
