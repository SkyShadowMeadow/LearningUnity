using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParallaxBackground : MonoBehaviour
{
    [SerializeField] private float _speed;
    private RawImage _image;
    private float _positionX;

    void Start()
    {
        _image = GetComponent<RawImage>();
        _positionX = _image.uvRect.x;
    }

    
    void FixedUpdate()
    {
        _positionX += _speed * Time.deltaTime;
        if (_positionX > 1) _positionX = 0;
        _image.uvRect = new Rect(_positionX, 0, _image.uvRect.width, _image.uvRect.height);

    }
}
