using UnityEngine;

namespace Project02
{
    public class PugaloMovementLerp : MonoBehaviour
    {
        [SerializeField] private Transform _targetPoint;

        void Update() =>
            transform.position = Vector2.Lerp(this.transform.position, _targetPoint.position, 0.02f);
    }
}
