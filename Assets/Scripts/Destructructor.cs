using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructructor : MonoBehaviour
{
    [SerializeField] float scatterForce = 5f; //cила рассыпания
    [SerializeField] string weaponTag = "Weapon"; //тэг объекта, вызывающего рассыпание
    [SerializeField] GameObject shatteredPipePrefab;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(weaponTag))
        {
            GameObject shatteredPipe = Instantiate(shatteredPipePrefab,
                transform.position, transform.rotation);

            foreach (Transform part in shatteredPipe.transform)
            {
                Rigidbody2D pipeShard = part.GetComponent<Rigidbody2D>();
                if (pipeShard != null)
                {
                    pipeShard.AddForce(new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f))* scatterForce,
                        ForceMode2D.Impulse);
                }
            }
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (transform.position.y < -15f)
        {
            Destroy(gameObject);
        }
    }
}
