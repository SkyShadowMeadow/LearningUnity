using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActivationOfLight : MonoBehaviour
{
    [SerializeField] private ParticleSystem _glow;

    public event UnityAction Reached;
    public bool IsReached { get; private set; }
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Player>(out Player player))
        {
            if (IsReached)
            {
                Reached?.Invoke();
            }
            else
            {
                _glow.gameObject.SetActive(true);
                IsReached = true;
                Reached?.Invoke();
            }
        }
    }
}
