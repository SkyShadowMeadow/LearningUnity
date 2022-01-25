using UnityEngine;

namespace Project01
{
    public class DetectEnemies : MonoBehaviour
    {
        private int _layerMask;

        void Start()
        {
            _layerMask = LayerMask.GetMask("Player");
            //everything except for the Player
            _layerMask = ~_layerMask;
        }

        void Update()
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, Mathf.Infinity, _layerMask);
            Debug.DrawLine(transform.position, transform.up * 10, Color.red);
            if (hit)
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
