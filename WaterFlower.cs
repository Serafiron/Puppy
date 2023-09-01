using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFlower : MonoBehaviour
{

    public GameObject projectile;
    public float timeBetweenShots;
    private float nextShotTime;
    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextShotTime)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            nextShotTime = Time.time + timeBetweenShots;
        }
    }
}
