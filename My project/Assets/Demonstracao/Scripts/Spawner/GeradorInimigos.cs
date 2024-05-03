using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorInimigos : MonoBehaviour
{
    [SerializeField] private Transform[] SpawnPosition;
    [SerializeField] private GameObject Enemy;
    [SerializeField] private float SpawnTime;
    private float Cronometer;
    
    // Update is called once per frame
    void Update()
    {
        Cronometer += Time.deltaTime;
        if(Cronometer >= SpawnTime)
        {
            CreateEnemy();
            Cronometer = 0;
        }
    }

    void CreateEnemy()
    {
        int index = Random.Range(0, SpawnPosition.Length);
        Instantiate(Enemy, SpawnPosition[index].position, SpawnPosition[index].rotation);
    }
}
