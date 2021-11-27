using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FlyInCharacters : MonoBehaviour
{
    [SerializeField] private RectTransform[] _rectTransforms;
    private Vector3 _positionOfTheFirstCharacter;
    private float _offset = 11;
    private void Awake()
    {
        _positionOfTheFirstCharacter = new Vector3(400, 242, 0);
    }

    public void FlyIn()
    {
        for (int i = 0; i < _rectTransforms.Length; i++)
        {
            _rectTransforms[i].DOMove(_positionOfTheFirstCharacter, 1f).SetLoops(1,LoopType.Restart);

            float nextXPosition = _rectTransforms[i].position.x -
                                    _rectTransforms[i].sizeDelta.x * _rectTransforms[i].localScale.x
                                    - _offset;
            _positionOfTheFirstCharacter = new Vector3(nextXPosition, _positionOfTheFirstCharacter.y, 0);
        }
    }

    public void FlyInWithoutDotween()
    {
        for (int i = 0; i <_rectTransforms.Length; i++)
        {
            _rectTransforms[i].position = _positionOfTheFirstCharacter;
            float nextXPosition = _rectTransforms[i].position.x -
                                    _rectTransforms[i].sizeDelta.x * _rectTransforms[i].localScale.x
                                    - _offset;
            _positionOfTheFirstCharacter = new Vector3(nextXPosition, _positionOfTheFirstCharacter.y, 0);
        }
    }

    IEnumerator StartFlyingIn()
    {
        yield return new WaitForSeconds(2f);

    }
}
