    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studentcreate : MonoBehaviour
{
    [SerializeField] int stundentsnumber = 0;
    [SerializeField] int maxstundentsnumber = 0;
    [SerializeField] float durationbetweenstudentscreation;

    [SerializeField] GameObject student;

    [SerializeField] float studentprefabx;
    [SerializeField] float studentprefaby;


    IEnumerator Start()
    {
        for (; stundentsnumber < maxstundentsnumber; stundentsnumber++)
        {
            if (stundentsnumber != maxstundentsnumber)
            {
                yield return StartCoroutine(Createstudent(durationbetweenstudentscreation));
            }
        }
        //print("Done " + Time.time);

    }

    IEnumerator Createstudent(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        Instantiate(student, new Vector2(studentprefabx, studentprefaby), Quaternion.identity);

        //print("Createstudent " + Time.time);

    }
}
