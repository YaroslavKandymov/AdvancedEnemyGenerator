using AdvancedEnemyGeneration.PreyComponents;
using UnityEngine;

namespace AdvancedEnemyGeneration.EnemyComponents
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private EnemyMover _mover;
        
        private void Awake()
        {
            _mover.Init(this);
        }

        public void Init(Prey target)
        {
            _mover.Move(target.transform);
        }
    }
}