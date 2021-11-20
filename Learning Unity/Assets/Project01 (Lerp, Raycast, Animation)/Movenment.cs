using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movenment : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
        }
    }
}
