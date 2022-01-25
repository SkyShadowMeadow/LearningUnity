using UnityEngine;

namespace EndlessRunner
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private int _damage = 1;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Player player))
            {
                player.ApplyDamage(_damage);

            }
            Die();
        }

        private void Die() => gameObject.SetActive(false);
    }
}
