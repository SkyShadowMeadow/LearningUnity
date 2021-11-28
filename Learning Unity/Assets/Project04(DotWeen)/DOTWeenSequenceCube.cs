using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTWeenSequenceCube : MonoBehaviour
{
    [SerializeField] private Vector3[] _waypoints;
    public void StartSequence()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOMoveX(3, 2).SetRelative());
        sequence.Insert(0, transform.DORotate(new Vector3(60, 30, 0),3));

        sequence.Append(transform.DOPath(_waypoints, 5, PathType.CatmullRom).SetRelative());
        sequence.SetLoops(-1, LoopType.Yoyo);
    }
}
