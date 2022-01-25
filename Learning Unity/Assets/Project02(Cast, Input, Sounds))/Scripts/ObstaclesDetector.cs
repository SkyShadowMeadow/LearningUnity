using UnityEngine;

namespace Project02
{
    public class ObstaclesDetector : MonoBehaviour
    {
        [SerializeField] private float _speed = 1f;
        [SerializeField] private ContactFilter2D _contactFilter;
        private readonly RaycastHit2D[] _collisionResults = new RaycastHit2D[1];
        private int _numberOfCollisions;
        private Rigidbody2D _rigidbody2D;

        void Start() =>
            _rigidbody2D = GetComponent<Rigidbody2D>();

        void Update()
        {
            _numberOfCollisions = _rigidbody2D.Cast(Vector2.right, _contactFilter, _collisionResults, 10f);
            if (_numberOfCollisions == 0)
            {
                _rigidbody2D.velocity = Vector2.right * _speed;
            }
            else
            {
                _rigidbody2D.velocity = new Vector2(0, 0);
            }
        }
    }
}
