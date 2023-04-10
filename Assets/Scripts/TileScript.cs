using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileScript : MonoBehaviour
{
    public bool isOccipied;

    public Color greenColor;
    public Color redColor;

    private SpriteRenderer colorRend;

    private void Start(){
        colorRend = GetComponent<SpriteRenderer>();
    }

    private void Update(){
        if(isOccipied == true){
            colorRend.color = redColor;

        }else{
            colorRend.color = greenColor;
        }
    }

}
