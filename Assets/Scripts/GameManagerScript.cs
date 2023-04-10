using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{

    public int gold;
    public int science;
    public int fun;
    public int capacity;
    public int students;

    public Text goldDisplay;
    public Text scienceDisplay;
    public Text funDisplay;
    public Text capacityDisplay;
    public Text studentsDisplay;
    public Text LoseText;
    public Text WinText;

    public GameObject Grid;
    public CustomCursorScript customCursor;
    public studentcreate sc;
    public TimerScript timerScript;

    public TileScript[] tiles;

    
    private BuildingScript buildingToPlace;
    

    private void Update(){
        goldDisplay.text = gold.ToString();
        scienceDisplay.text = science.ToString();
        funDisplay.text = fun.ToString();
        capacityDisplay.text = capacity.ToString();
        studentsDisplay.text = students.ToString();
        sc.maxstundentsnumber = fun;

        if(Input.GetMouseButton(0) && buildingToPlace != null){
            TileScript nearestTile = null;
            float shortestDistance = float.MaxValue;
            foreach(TileScript tile in tiles){
                float dist = Vector2.Distance(tile.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
                if(dist < shortestDistance){
                    shortestDistance = dist;
                    nearestTile = tile; 
                }
            }
            if(nearestTile.isOccipied == false){
                Instantiate(buildingToPlace, nearestTile.transform.position, Quaternion.identity);
                buildingToPlace = null;
                nearestTile.isOccipied = true;
                Grid.SetActive(false);
                customCursor.gameObject.SetActive(false);
                Cursor.visible=true;
            }
        }
        if(science<=0){
            LoseText.gameObject.SetActive(true);
        }else if(timerScript.TimeLeft<=0.0f){
            LoseText.gameObject.SetActive(true);
        }
        else if(students>=50){
            WinText.gameObject.SetActive(true);
        }
    }
    
    public void BuyBuilding(BuildingScript building){
        if(gold >= building.buildCost){
            customCursor.gameObject.SetActive(true);
            customCursor.GetComponent<SpriteRenderer>().sprite = building.GetComponent<SpriteRenderer>().sprite;
            Cursor.visible=false;

            gold -= building.buildCost;
            buildingToPlace = building;
            Grid.SetActive(true);
        }

    }
  
}

