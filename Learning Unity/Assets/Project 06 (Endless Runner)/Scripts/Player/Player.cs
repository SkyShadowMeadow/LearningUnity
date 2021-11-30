using UnityEngine;
namespace EndlessRunner
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private int _health;

        public void ApplyDamage(int damage)
        {
            _health -= damage;
            if (_health <= 0)
                Die();
        }
        private void Die() { }
    }
}