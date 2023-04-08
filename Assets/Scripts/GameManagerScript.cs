using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public int gold;
    public Text goldDisplay;

    public GameObject Grid;
    public CustomCursorScript customCursor;

    public TileScript[] tiles;

    private BuildingScript buildingToPlace;
    

    private void Update(){
        goldDisplay.text = gold.ToString();

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
