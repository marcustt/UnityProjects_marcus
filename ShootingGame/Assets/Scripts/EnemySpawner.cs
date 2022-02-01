using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //프리팹용 게임오브젝트
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] private float spawnDelay = 2f;
    float elapsedTime = 0f ;

    Transform tr;



    void Start()
    {
        //총알생성 위치
        tr = gameObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        float timeOfMake = 0f;
        if(elapsedTime>spawnDelay)
        {
            Instantiate(enemyPrefab, tr);
            elapsedTime = 0;
        }
        elapsedTime += Time.deltaTime;
    }
}
