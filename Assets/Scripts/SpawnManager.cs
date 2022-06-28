using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFSW.MOP2;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private ObjectPool zombunnyPool;

    [SerializeField] private Transform spawnPos1;
    [SerializeField] private Transform spawnPos2;
    [SerializeField] private Transform spawnPos3;
    
    void Start()
    {
        StartCoroutine(SpawnZombunny());
    }

    IEnumerator SpawnZombunny()
    {
        yield return new WaitForSeconds(Random.Range(1, 3));
        zombunnyPool.GetObject(spawnPos1.position);
        zombunnyPool.GetObject(spawnPos2.position);
        zombunnyPool.GetObject(spawnPos3.position);
        StartCoroutine(SpawnZombunny());
    }
    
}
