using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace EndlessRunner
{
    public class HealthDisplay : MonoBehaviour
    {
        [SerializeField] private Player _player;
        private TMP_Text _tmpText;

        private void Awake()
        {
            _tmpText = GetComponent<TMP_Text>();
        }

        private void OnEnable()
        {
            _player.HealthChanged += OnHealthChanged;
        }
        private void OnDisable()
        {
            _player.HealthChanged -= OnHealthChanged;
        }

        private void OnHealthChanged(int newHealth)
        {
            _tmpText.text = newHealth.ToString();
        }
    }
}
