using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrower : MonoBehaviour
{
    [SerializeField] float throwForce = 10f;  //Сила метания ножа
    [SerializeField] GameObject throwObjPrefab;  //что мы метаем
    [SerializeField] Transform spawnPoint;  //точка появления
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            ThrowD20();
        }
    }

    void ThrowD20()
    {
        GameObject knife = Instantiate(throwObjPrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody2D knifeRigidBody = knife.GetComponent<Rigidbody2D>();

        knifeRigidBody.AddForce(spawnPoint.right * throwForce, ForceMode2D.Impulse); 
    }
}
