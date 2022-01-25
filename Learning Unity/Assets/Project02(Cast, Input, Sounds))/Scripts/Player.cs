using UnityEngine;
using UnityEngine.Events;

namespace Project02
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private UnityEvent _hit;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.TryGetComponent(out BarrelMovenmentUp barrelMovenmentUp))
            {
                _hit?.Invoke();
            }
        }
    }
}
