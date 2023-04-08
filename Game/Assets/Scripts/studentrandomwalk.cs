using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class studentrandomwalk : MonoBehaviour
{

    public waypoints waypointscript;
    public int waypointindex;
    public float distance;
    public float speed;

    private void Awake()
    {
        waypointscript = GameObject.Find("GameManager").GetComponent<waypoints>();
    }

    private void Start()
    {
        waypointindex = Random.Range(0, 4);
    }
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypointscript.waypoint[waypointindex].transform.position,speed*Time.deltaTime);

        if (Vector2.Distance(transform.position, waypointscript.waypoint[waypointindex].transform.position) < distance)
        {
            waypointindex = Random.Range(0, 4);
        }
    }



}
 