using UnityEngine;
using UnityEngine.Events;

namespace EndlessRunner
{
    public class Player : MonoBehaviour
    {
        public event UnityAction<int> HealthChanged;
        public event UnityAction Died;

        [SerializeField] private int _health;

        private void Start()
        {
            HealthChanged?.Invoke(_health);
        }
        public void ApplyDamage(int damage)
        {
            _health -= damage;
            HealthChanged?.Invoke(_health);

            if (_health <= 0)
                Die();
        }
        private void Die() { Died?.Invoke(); }
    }
}