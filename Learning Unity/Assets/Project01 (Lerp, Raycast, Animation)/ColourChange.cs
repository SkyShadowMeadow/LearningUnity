using UnityEngine;

namespace Project01
{
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
}
