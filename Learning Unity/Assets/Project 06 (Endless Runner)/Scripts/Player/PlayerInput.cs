using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunner
{
    [RequireComponent(typeof(PlayerMover))]
    public class PlayerInput : MonoBehaviour
    {
        private PlayerMover _playerMover;

        void Start()
        {
            _playerMover = GetComponent<PlayerMover>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                _playerMover.TryMoveUp();
            }
            if (Input.GetKey(KeyCode.S))
            {
                _playerMover.TryMoveDown();
            }
        }
    }
}
