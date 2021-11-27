using UnityEngine;
using DG.Tweening;

public class LargeBoardFlyIn : MonoBehaviour
{
    [SerializeField] private RectTransform _rectTransform;
    [SerializeField] private float _targetScale;
    [SerializeField] private float _targetPositionX;

    public void FlyIn()
    {
        _rectTransform.DOLocalMoveX(_targetPositionX, 2f).OnComplete(Scale);
    }
    public void Scale()
    {
        _rectTransform.DOScale(_targetScale, 1f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
