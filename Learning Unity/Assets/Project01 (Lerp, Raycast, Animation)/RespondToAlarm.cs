using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project01
{
    public class RespondToAlarm : MonoBehaviour
    {
        private Animator _animator;

        void Start()=>
            _animator = GetComponent<Animator>();

        private void OnMouseDown() =>
            _animator.SetTrigger("OnAlarmed");
    }
}
