using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private float _timeBetweenSpawns = 1f;
    [SerializeField] private Transform[] _spawnPoints;

    private float _timeFromLastSpawn = 0;

    void Start()
    {
       InitializePool(_prefab);
    }

    // Update is called once per frame
    void Update()
    {
        _timeFromLastSpawn += Time.deltaTime;
        if (_timeFromLastSpawn >= _timeBetweenSpawns)
        {
            if(TryGetObjectInPool(out GameObject enemy))
            {
                Transform randomPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
                SetEnemy(enemy, randomPoint.position);
            }
        }    
    }
    private void SetEnemy(GameObject enemy, Vector2 position)
    {
        enemy.SetActive(true);
        enemy.transform.position = position;
        _timeFromLastSpawn = 0;
    }
}
