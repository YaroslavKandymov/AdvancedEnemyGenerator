using System;
using System.Collections;
using UnityEngine;

namespace AdvancedEnemyGeneration.PreyComponents
{
    [Serializable]
    public class PreyMover
    {
        [SerializeField] private Transform[] _path;
        [SerializeField] private float _speed;
        [SerializeField] private float _minDistance;
        
        private MonoBehaviour _self;

        public void Init(MonoBehaviour self)
        {
            _self = self;
        }

        public void Move()
        {
            _self.StartCoroutine(MoveOnPath());
        }

        private IEnumerator MoveOnPath()
        {
            int currentPointIndex = 0;
            
            while (true)
            {
                var targetPoint = _path[currentPointIndex].position;
                
                _self.transform.position = Vector3.MoveTowards(_self.transform.position, targetPoint,
                    _speed * Time.deltaTime);

                if (Vector3.Distance(_self.transform.position, targetPoint) <= _minDistance)
                {
                    currentPointIndex++;

                    if (currentPointIndex >= _path.Length)
                    {
                        currentPointIndex = 0;
                    }
                }

                yield return null;
            }
        }
    }
}