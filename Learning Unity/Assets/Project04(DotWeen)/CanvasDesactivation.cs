using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DOTweenProject
{
    public class CanvasDesactivation : MonoBehaviour
    {
        public UnityEvent OnDesactivate;
        [SerializeField] private Canvas _canvas;

        public void Desactivate()
        {
            _canvas.gameObject.SetActive(false);
            OnDesactivate?.Invoke();
        }
    }
}
