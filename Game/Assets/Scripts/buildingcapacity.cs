using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingcapacity : MonoBehaviour
{
    [SerializeField] int capacity = 0;
    [SerializeField] int maxCapacity;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        capacity++;
        if (capacity == maxCapacity)
        {
            Debug.Log("Max capacity");
            collision.gameObject.SetActive(false);
        }
        else if (capacity != maxCapacity)
        {
            Debug.Log("Yer var");
        }
    }
}
