using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PugaloMovementLerp : MonoBehaviour
{
    [SerializeField] private Transform _targetPoint; 

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(this.transform.position, _targetPoint.position, 0.02f);
    }
}
