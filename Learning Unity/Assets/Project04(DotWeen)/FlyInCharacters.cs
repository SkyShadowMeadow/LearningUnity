using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FlyInCharacters : MonoBehaviour
{
    [SerializeField] private RectTransform _rectTransform;
    [SerializeField] private RectTransform _targetPoint;
    private Vector3 _positionOfTheCharacter;

    private void Awake()
    {
        _positionOfTheCharacter = _targetPoint.position;
    }

    public void FlyIn()
    {
        _rectTransform.DOMove(_positionOfTheCharacter, 2f).SetLoops(2, LoopType.Restart);
    }
}
