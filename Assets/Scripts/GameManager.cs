using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private float maxRangeZ;
    [SerializeField]
    private float maxRangeX;
    [SerializeField]
    private float heightY;
    void Start()
    {
        InvokeRepeating("CreateEnemy" , 5.0f , 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateEnemy()
    {
        Instantiate(enemyPrefab ,
        new Vector3(Random.Range(-maxRangeX , maxRangeX) , heightY , maxRangeZ) ,
        enemyPrefab.transform.rotation);
    }
}
