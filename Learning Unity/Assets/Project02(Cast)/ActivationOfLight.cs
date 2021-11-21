using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationOfLight : MonoBehaviour
{
    [SerializeField] private ParticleSystem _glow; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Player>(out Player player))
        {
            _glow.gameObject.SetActive(true);
        }
    }
}
