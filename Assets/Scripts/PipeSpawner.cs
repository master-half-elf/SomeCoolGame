using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipesPrefab;

    public float spawnRate = 2f;  //частота по€влени€ (сек)
    public float heightOffset = 1f; //смещение диапазона смещени€ труб по вертикали

    void Start()
    {
        StartCoroutine( SpawnPipeRoutine()   );
    }

    IEnumerator SpawnPipeRoutine()
    {
        while ( true ) 
        { 
            yield return new WaitForSeconds( spawnRate );

            float yPos = Random.Range(-heightOffset, heightOffset);  //рандомлю положение труб по Y
            Vector3 spawnPosition = new Vector3 ( transform.position.x, yPos, 0 );
            Instantiate(pipesPrefab, spawnPosition, Quaternion.identity);
        }
    }



    /*  
     *  
     *  
     *              //yield return new WaitForSecondsRealtime( spawnRate );  

                //используйте с осторожностью
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
            «апускаю код
        }
    }

    2. Invoke

    void Start()
    {
        Invoke("SpawnPipes", 2f);
    }

    void SpawnPipes()
    {
        код вызова труб!
    }



    **********************************************
        4. InvokeRepeating
            void Start()
        {
            InvokeRepeating("SpawnPipes", 2f, 3f); ¬ызову метод SpawnPipes(), через 2 секунды, 
            и повтор€ю каждые 3 секунды
        }

        void SpawnPipes()
        {
            код вызова труб!
        }

        5) Update c использованием Time.deltaTime

        6) Task и async/await

        */
}
