using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    [SerializeField] private float _timeToChangeColour = 2f;
    [SerializeField] private Color _targetColour;

    private SpriteRenderer _spriteRenderer;
    private Color _startColour;
    private float _runningTime;
    private float _normalizedTime;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _startColour = _spriteRenderer.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (_runningTime <= _timeToChangeColour)
        {
            _runningTime += Time.deltaTime;
            _normalizedTime = _runningTime / _timeToChangeColour;
            _spriteRenderer.color = Color.Lerp(_startColour, _targetColour, _normalizedTime);

        }
    }
}
