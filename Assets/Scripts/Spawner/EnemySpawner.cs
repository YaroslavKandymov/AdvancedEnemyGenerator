using System.Collections;
using AdvancedEnemyGeneration.Factories;
using UnityEngine;

namespace AdvancedEnemyGeneration.Spawner
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private SpawnPoint[] _spawnPoints;
        [SerializeField] private EnemyFactory _factory;
        [SerializeField] private float _timeBetweenSpawn;
        
        private void Start()
        {
            StartCoroutine(SpawnEnemy());
        }

        private IEnumerator SpawnEnemy()
        {
            var seconds = new WaitForSeconds(_timeBetweenSpawn);
            var index = 0;
            
            while (true)
            {
                var currentPoint = _spawnPoints[index];

                var enemy = _factory.GetPrefab(currentPoint.Type, currentPoint.transform);
                enemy.Init(currentPoint.Target);

                index++;

                if (index >= _spawnPoints.Length)
                {
                    index = 0;
                }

                yield return seconds;
            }
        }
    }
}