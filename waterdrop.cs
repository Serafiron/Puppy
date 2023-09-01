using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;
using UnityEngine.UIElements;
using System;

public class waterdrop : MonoBehaviour
{
    Vector3 targetPosition;

    //set the falling speed here
    public float speed;

    private void Start()
    {
        targetPosition = FindObjectOfType<Rigidbody2D>().transform.position;

    }

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime, Space.World);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
            Destroy(this.gameObject);
    }
}
