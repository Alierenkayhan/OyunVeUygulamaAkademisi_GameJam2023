using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studentcreate : MonoBehaviour
{
    
    [SerializeField] int stundentsnumber = 0;
    public int maxstundentsnumber = 10;
    [SerializeField] float durationbetweenstudentscreation;
    private float nextCreateTime=0.0f;

    [SerializeField] GameObject student;

    [SerializeField] float studentprefabx;
    [SerializeField] float studentprefaby;

     private void Update()
    {
        if (stundentsnumber < maxstundentsnumber)
        { 
            if(Time.time > nextCreateTime){
            nextCreateTime = Time.time + durationbetweenstudentscreation;
            Instantiate(student, new Vector2(studentprefabx, studentprefaby), Quaternion.identity);
            stundentsnumber++;  
        }   
        
        }

       
    }

    
}
