using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] float upForce = 200f;
    int score = 0;

    Rigidbody2D birdRigidBody2D;
    bool isDead;  //false по умолчанию

    public float tiltSmooth = 4f; //скорость наклона
    public float maxTiltAngle = 30f;  //максимальный угол наклона (движение вверх)
    public float minTiltAngle = -30f;//минимальный угол наклона (движение вниз)

    void Start()
    {
        birdRigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDead)
        {
            birdRigidBody2D.velocity = Vector2.zero;  //обнул€ю ускорение
            birdRigidBody2D.AddForce(new Vector2(0, upForce));  //задаю ускорение

        }

        float tiltAngle;
        if (birdRigidBody2D.velocity.y > 0)
        {
            tiltAngle = maxTiltAngle;
        }
        else
        {
            tiltAngle = minTiltAngle;
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, tiltAngle),
            tiltSmooth * Time.deltaTime);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isDead) 
        {
            isDead = true;
            transform.rotation = Quaternion.Euler(0f, 0f, minTiltAngle);
            birdRigidBody2D.velocity = Vector2.zero;
        }
    }

    //Cистема движени€ в ёнити:
    //ўас продолжим
    /*
     * 
     * 
        1) Transform.Translate()  это перемещение относительно текущей позиции
        Transform.Translate( Vector3.right * Time.deltaTime)

        new Vector3( 10f , 0f , 0f ),  аналог -> Vector3.right, Vector3.left, Vector3.zero


        2) Transform.position = Transform.position + new Vector3( 10f , 0f , 0f ) * Time.deltaTime


        2.5) Transform.position = new Vector3( 10f , 0f , 0f ); ///дл€ телепортов, дл€ перемещени€
    без физики, позиционирование

        3)  
        Rigidbody2D rigidBody2D;
        void Start()
        {
            rigidBody2D = GetComponent<Rigidbody2D>();
            rigidBody2D.velocity = new Vector3( 10f , 0f , 0f )
        }


    void Update()
    {
       float move = Input.GetAxis("Horizontal")
       rigidBody2D.velocity = new Vector3 (move,  rigidBody2D.velocity.y,  rigidBody2D.velocity.z);
    }
    rigidBody2D.velocity = new Vector3(Mathf.Clamp( move,  -10f,  10f), 0f, 0f);


    4) rigidBody2D.AddForce( Vector3.right * 10f )  1кг, 10м/с2      в Ќьютонах

    4.1) rigidBody2D.AddForce( Input.GetAxis("Horizontal") * 10 f , Impulse); 

    4.2) rigidBody2D.AddForce( Vector3.right * 10f , Acceleration);


    »нтерпол€ци€ движени€: 


    Ћинейна€ интерпол€ци€:

    Vector3 startPos = transform.position;
    Vector3 endPosition = new Vector3(10f,10f,0f);
    float moveTime = 3f;
    float elapsedTime = 0f;

    void Update()
    {
        elapsedTime = elapsedTime + Time.deltaTime;
        transform.position = Vector3.Lerp(startPos, endPosition, elapsedTime/moveTime);
    }

    //SmoothDamp 

    Vector3 targetPosition = new Vector3(10f,10f,0f);
    Vector3 velocity = Vector3.zero;
    float smoothTime = 3f;
    maxSpeed = Mathf.Infinity;

    void Update()
    {
        transform.position = Vector3.SmoothDamp(transfom.position, targetPosition, ref velocity, 
    smoothTime, maxSpeed, float deltaTime = Time.deltaTime);
    )
    }

    //Slerp 
    void Update()
    {
        Quaternion targetRotation = Quaternion.LookRotation(Vector3.left);
        transform.rotation = Quaternion.Slerp(transfrom.rotation, targetRotation, Time.deltaTime);
    }


    Vector3 target = newVector3(10f, 10f, 10f);
    void Update()
    {
        transform.LookAt(target)
        
    }



    */
}
