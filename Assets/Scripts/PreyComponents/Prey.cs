using UnityEngine;

namespace AdvancedEnemyGeneration.PreyComponents
{
    public class Prey : MonoBehaviour
    {
        [SerializeField] private PreyMover _preyMover;

        private void Start()
        {
            _preyMover.Init(this);
            _preyMover.Move();
        }
    }
}