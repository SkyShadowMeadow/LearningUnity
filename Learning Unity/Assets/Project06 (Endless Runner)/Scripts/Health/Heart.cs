using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace EndlessRunner
{
    public class Heart : MonoBehaviour
    {
        private Image _image;
        [SerializeField] private float _lerpDuration = 1;

        private void Awake()
        {
            _image = GetComponent<Image>();
            _image.fillAmount = 1;
        }

        public void ToFill() => 
            StartCoroutine(Filling(0, 1, _lerpDuration, Fill));

        public void ToEmpty() => 
            StartCoroutine(Filling(1, 0, _lerpDuration, Empty));

        private IEnumerator Filling(float startValue, float endValue, float duration, UnityAction<float> lerpingEnd)
        {
            float passedTime = 0;
            float nextValue;
            while (passedTime < duration)
            {
                nextValue = Mathf.Lerp(startValue, endValue, passedTime / duration);
                _image.fillAmount = nextValue;
                passedTime += Time.deltaTime;
                yield return null;
            }
            lerpingEnd?.Invoke(endValue);
        }

        private void Fill(float value) =>
            _image.fillAmount = value;

        private void Empty(float value)
        {
            _image.fillAmount = value;
            Destroy(gameObject);
        }
    }
}