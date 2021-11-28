using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Follower : MonoBehaviour
{
    [SerializeField] private RectTransform _target;
    private float _offset = 85;
    private RectTransform _rectTransform;
    private Vector3 _targetLastPosition;
    Tweener _tween;

    private void Awake()
    {
        _rectTransform = gameObject.GetComponent<RectTransform>();
    }
    void Start()
    {
        _tween = _rectTransform.DOMove(new Vector3(_target.position.x - _offset,_target.position.y,0), 2f).SetAutoKill(false);
        _targetLastPosition = _rectTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(_target.position != _targetLastPosition)
        {
            _tween.ChangeEndValue(new Vector3(_target.position.x - _offset, _target.position.y, 0), true).Restart();
            _targetLastPosition = _target.position;
        }
    }
}
