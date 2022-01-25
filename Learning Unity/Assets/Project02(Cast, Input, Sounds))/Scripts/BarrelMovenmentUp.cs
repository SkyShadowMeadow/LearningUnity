using UnityEngine;
using UnityEngine.EventSystems;

namespace Project02
{
    public class BarrelMovenmentUp : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private float speed = 200f;

        public void OnPointerClick(PointerEventData eventData) =>
            _rigidbody.AddForce(Vector2.up * speed);
    }
}
