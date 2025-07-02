using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Mathf_testing : MonoBehaviour
{
    //Mathf;

    float absValue1 = UnityEngine.Mathf.Abs(1.5f);

    float absValue2 = System.Math.Abs(1.5f);

    //Deg2Rad - градусы в радианы 

    float radians = 45f * Mathf.Deg2Rad;

    //Epsilon
    private void Start()
    {
        if (Mathf.Abs(1.0000001f - 1.0000002f) < Mathf.Epsilon) //1.401298 E-45
        {
            Debug.Log("Числа примерно равны");
        }

        float x = 0.0000001f;
        if (Mathf.Abs(x) > Mathf.Epsilon)
        {
            float result = 1.0f / x;
        }
        else
        {
            //число очень близко к нулю, возможна ошибка
        }

        //Mathf.Infinity - представление положительной бесконечности 



    }
    [SerializeField] Transform[] enemies;
    Transform closestEnemy;

    void FindClosestEnemy()
    {
        float shortestDistance = Mathf.Infinity;

        foreach (Transform enemy in enemies) 
        {
            float distance = Vector3.Distance(transform.position, enemy.position);
            if (distance < shortestDistance)
            {
                shortestDistance = distance;
                closestEnemy = enemy;
            }
        }
    }

    //Mathf.NegativeInfinity;

    //Mathf.PI   

    //Mathf.Rad2Deg - радианы в градусы 

    //Mathf.Abs() - модуль числа

    //Mathf.Acos() арккосинус числа (радианы)

    //Mathf.Asin()

    //Mathf.Atan()

    //bool areEqual = Mathf.Approximately(0.1f + 0.2f,  0.3f); //true 

    //Mathf.Ceil(  2.3f ) округление вверх 3.0f

    //Mathf.CeilToInt(  2.3f  )   3

    //Mathf.Clamp( value, minValue, maxValue );
    //Mathf.Clamp( 5, 0, 10 );

    //Mathf.Clamp01(value);

    //Mathf.ClosestPowerOfTwo(value); - возвращает ближайшую степень двойки 

    //Color color = Mathf.CorrelatedColorTemperatureToRGB(value); - преобразует цветовую температуру в Кельвинах
    //в RGB 

    //Mathf.Cos()
    //Mathf.Sin()

    //Mathf.DeltaAngle(angle1, angle2)  - вычисляет наименьшее
    //различие между двумя углами, заданными в градусах.





}
