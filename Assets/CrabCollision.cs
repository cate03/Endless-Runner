using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabCollision : MonoBehaviour
{
    public float speed = 2;


    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //reset player
        }

    }
}
