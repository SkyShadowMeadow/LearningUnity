using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevelMonitor : MonoBehaviour
{
    private ActivationOfLight[] _points;
    private bool[] _pointsAreActivated;
    private void Awake()
    {
        _points = GetComponentsInChildren<ActivationOfLight>();
        _pointsAreActivated = new bool[_points.Length];
    }
    private void OnEnable()
    {
        _points = GetComponentsInChildren<ActivationOfLight>();

        foreach (ActivationOfLight point in _points)
        {
            point.Reached += CheckIfLevelIsFinished;
        }
    }

    private void CheckIfLevelIsFinished()
    {
        foreach (ActivationOfLight point in _points)
        {
            if (point.IsReached == false)
                return;
        }
        Debug.Log("Level is finished");
    }
}
