using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipesPrefab;

    public float spawnRate = 2f;  //������� ��������� (���)
    public float heightOffset = 1f; //�������� ��������� �������� ���� �� ���������

    void Start()
    {
        StartCoroutine( SpawnPipeRoutine()   );
    }

    IEnumerator SpawnPipeRoutine()
    {
        while ( true ) 
        { 
            yield return new WaitForSeconds( spawnRate );

            float yPos = Random.Range(-heightOffset, heightOffset);  //�������� ��������� ���� �� Y
            Vector3 spawnPosition = new Vector3 ( transform.position.x, yPos, 0 );
            Instantiate(pipesPrefab, spawnPosition, Quaternion.identity);
        }
    }



    /*  
     *  
     *  
     *              //yield return new WaitForSecondsRealtime( spawnRate );  

                //����������� � �������������
                //yield return new WaitForFixedUpdate( spawnRate );
                //yield return new WaitUntil(() => playerHealth <=0);
                //yield return new WaitWhile(() => isPaused);
     *  1. Time.time;
     * 
    float delayTime = 2f;
    float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (Time.time >= startTime + delayTime)
        {
            �������� ���
        }
    }

    2. Invoke

    void Start()
    {
        Invoke("SpawnPipes", 2f);
    }

    void SpawnPipes()
    {
        ��� ������ ����!
    }



    **********************************************
        4. InvokeRepeating
            void Start()
        {
            InvokeRepeating("SpawnPipes", 2f, 3f); ������ ����� SpawnPipes(), ����� 2 �������, 
            � �������� ������ 3 �������
        }

        void SpawnPipes()
        {
            ��� ������ ����!
        }

        5) Update c �������������� Time.deltaTime

        6) Task � async/await

        */
}
