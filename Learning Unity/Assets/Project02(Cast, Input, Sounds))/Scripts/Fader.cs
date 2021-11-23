using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour
{
    [SerializeField] private Image _image;

    void Start()
    {
        var fadeInWork = StartCoroutine(FadeIn());
    }

    private IEnumerator FadeIn()
    {
        var currentColor = _image.color;
        for (int i = 0; i < 255; i++)
        {
            float minus = 0.01f;
            currentColor.a -= minus;
            _image.color = currentColor;
            yield return null;
        }
        _image.gameObject.SetActive(false);
    }

}
