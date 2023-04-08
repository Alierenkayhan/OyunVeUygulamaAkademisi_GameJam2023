using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studentcreate : MonoBehaviour
{
    [SerializeField] int stundentsnumber = 0;
    [SerializeField] int maxstundentsnumber = 0;

    [SerializeField] GameObject student;

    [SerializeField] float studentprefabx;
    [SerializeField] float studentprefaby;
    private void Start()
    {
        for (; stundentsnumber < maxstundentsnumber; stundentsnumber++)
        {
            if (stundentsnumber != maxstundentsnumber)
            {
                Instantiate(student, new Vector2(studentprefabx, studentprefaby), Quaternion.identity);
            }
        }
    }
}
