using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    Rigidbody2D knifeRb;
    /*void OnCollisionEnter2D(Collision2D collision)
{
    Destroy(gameObject);
    Destroy(collision.gameObject);
}*/
    void Start()
    {
        knifeRb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
        /*knifeRb.velocity = Vector2.zero;
        transform.parent = collision.transform;
        knifeRb.isKinematic = true;
        GetComponent<Collider2D>().enabled = false;*/

    }
}
