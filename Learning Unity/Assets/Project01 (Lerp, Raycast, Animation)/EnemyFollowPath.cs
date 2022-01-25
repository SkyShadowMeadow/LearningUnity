using UnityEngine;

namespace Project01
{
    public class EnemyFollowPath : MonoBehaviour
    {
        [SerializeField] private Transform _path;
        [SerializeField] private float speed = 2f;

        private Transform[] _pointsOfPath;
        private int _currentPoint;
        private Transform target;

        void Start()
        {
            _pointsOfPath = new Transform[_path.childCount];
            for (int i = 0; i < _path.childCount; i++)
            {
                _pointsOfPath[i] = _path.GetChild(i);
            }
            _currentPoint = 0;
        }

        void Update()
        {
            target = _pointsOfPath[_currentPoint];
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            if (transform.position == target.position)
            {
                _currentPoint++;
                if (_currentPoint >= _pointsOfPath.Length)
                {
                    _currentPoint = 0;
                }
            }
        }
    }
}
