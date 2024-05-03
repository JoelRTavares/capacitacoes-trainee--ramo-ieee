using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] SpawnPosition;
    [SerializeField] private GameObject Enemy;
    [SerializeField] private float TimeToSpawn;
    private float Cronometer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cronometer += Time.deltaTime;

        if(Cronometer >= TimeToSpawn)
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
