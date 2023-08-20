using System;
using System.Collections;
using UnityEngine;

namespace AdvancedEnemyGeneration.EnemyComponents
{
    [Serializable]
    public class EnemyMover
    {
        [SerializeField] private float _speed;

        private MonoBehaviour _self;

        public void Init(MonoBehaviour self)
        {
            _self = self;
        }

        public void Move(Transform target)
        {
            _self.StartCoroutine(MoveToPoint(target));
        }

        private IEnumerator MoveToPoint(Transform target)
        {
            while (true)
            {
                _self.transform.position = Vector3.MoveTowards(_self.transform.position, target.position,
                    _speed * Time.deltaTime);

                yield return null;
            }
        }
    }
}