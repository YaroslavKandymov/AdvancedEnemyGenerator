using AdvancedEnemyGeneration.Enums;
using AdvancedEnemyGeneration.PreyComponents;
using UnityEngine;

namespace AdvancedEnemyGeneration.Spawner
{
    public class SpawnPoint : MonoBehaviour
    {
        [SerializeField] private Prey _target;
        [SerializeField] private EnemyTypes _type;

        public Prey Target => _target;
        public EnemyTypes Type => _type;
    }
}