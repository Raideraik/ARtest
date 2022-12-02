using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Player _targer;
    [SerializeField] private float _spawnRadius;
    [SerializeField] private float _secondBetweenSpawn;
    [SerializeField] private int _maxEnemy;
    [SerializeField] private Transform[] _enemies;

    private int _enemyCount = 0;
    private void Start()
    {
        StartCoroutine(SpawnRandomEnemy());
    }

    private Vector3 GetRandomPlaceInSphere(float radius)
    {
        return Random.insideUnitSphere * radius;
    }

    private void OnEnemyDied(Enemy enemy)
    {

        enemy.Dying -= OnEnemyDied;

        _enemyCount--;
        _targer.AddScore();
    }

    private IEnumerator SpawnRandomEnemy()
    {
        while (true)
        {
            if (_maxEnemy > _enemyCount)
            {

                Transform newEnemy = Instantiate(_enemies[Random.Range(0, _enemies.Length)], GetRandomPlaceInSphere(_spawnRadius), Quaternion.identity);


                Enemy enemy = newEnemy.GetComponentInChildren<Enemy>();
                enemy.Dying += OnEnemyDied;

                _enemyCount++;
            }

            yield return new WaitForSeconds(_secondBetweenSpawn);
        }
    }
}
