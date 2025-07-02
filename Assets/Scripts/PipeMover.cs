using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] float coordToDestroy = -15f;  //дополнение к первому

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < coordToDestroy)  //решение 1
        {
            Destroy(gameObject);
        }
    }

    /*void OnTriggerEnter2D(Collider2D collision)  //решение 2
    {
        Destroy(gameObject);
    }*/
}
