using UnityEngine;

namespace EndlessRunner
{
    public class EnemyMover : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed = 3f;

        void Update() =>
            transform.Translate(Vector2.left * _moveSpeed * Time.deltaTime);
    }
}
