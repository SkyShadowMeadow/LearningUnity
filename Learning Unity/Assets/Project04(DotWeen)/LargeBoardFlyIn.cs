using UnityEngine;
using DG.Tweening;

namespace DOTweenProject
{
    public class LargeBoardFlyIn : MonoBehaviour
    {
        [SerializeField] private RectTransform _rectTransform;
        [SerializeField] private float _targetScale;
        [SerializeField] private float _targetPositionX;

        public void FlyIn() =>
            _rectTransform.DOLocalMoveX(_targetPositionX, 2f).OnComplete(Scale);

        public void Scale() =>
            _rectTransform.DOScale(_targetScale, 1f);
    }
}
