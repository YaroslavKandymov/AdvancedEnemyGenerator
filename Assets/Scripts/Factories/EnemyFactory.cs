using System;
using AdvancedEnemyGeneration.EnemyComponents;
using AdvancedEnemyGeneration.Enums;
using UnityEngine;

namespace AdvancedEnemyGeneration.Factories
{
    public class EnemyFactory : MonoBehaviour
    {
        [SerializeField] private Enemy _human;
        [SerializeField] private Enemy _vampire;
        [SerializeField] private Enemy _beast;
        [SerializeField] private Enemy _ghost;

        public Enemy GetPrefab(EnemyTypes type, Transform targetPoint)
        {
            Enemy instance = GetInstance(type);
            Enemy prefab = Instantiate(instance, targetPoint.position, Quaternion.identity);

            return prefab;
        }

        private Enemy GetInstance(EnemyTypes type)
        {
            switch (type)
            {
                case EnemyTypes.Human:
                    return _human;
                case EnemyTypes.Vampire:
                    return _vampire;
                case EnemyTypes.Beast:
                    return _beast;
                case EnemyTypes.Ghost:
                    return _ghost;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}