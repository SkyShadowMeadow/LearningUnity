using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 0.5f;
    [SerializeField] private float _stepSize = 0.5f;
    [SerializeField] private float _maxPosition = 5.0f;
    [SerializeField] private float _minPosition = -2.15f;

    private void Start()
    {
        _targetPosition = transform.position;
    }

    private Vector2 _targetPosition;

    public void TryMoveUp()
    {
        if (_targetPosition.y + _stepSize < _maxPosition)
            SetTargetPostion(_stepSize);
    }
    public void TryMoveDown()
    {
        if (_targetPosition.y - _stepSize > _minPosition)
            SetTargetPostion(-_stepSize);
    }
    public void SetTargetPostion(float stepSize)
    {
        _targetPosition = new Vector2(transform.position.x, transform.position.y + stepSize);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _targetPosition, _moveSpeed * Time.deltaTime);
    }
}
