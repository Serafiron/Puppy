using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyPatrol : MonoBehaviour
{
    public float speed;
    public Transform[] patrolPoints;
    public float waitTime;
    int currentPointIndex;

    bool once;

    private void Start()
    {
        currentPointIndex = 0;
    }

    

    private void Update()
    {
        if (MoveTo(patrolPoints[currentPointIndex]))
        {
            currentPointIndex = (currentPointIndex +1) % patrolPoints.Length;
        }
     /*   else
        {
            if (once == false)
            {
            StartCoroutine(Wait());
            }

        }
        */
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        if (currentPointIndex + 1 < patrolPoints.Length)
        {
            currentPointIndex++;
        }
        else
        {
            currentPointIndex = 0;
        }
        once = false;


    }

    private bool MoveTo(Transform patrolPoint)
    {
        if (transform.position != patrolPoint.position)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoint.position, speed * Time.deltaTime);
            return false;
        }
        return true;
    }

}
