using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private Transform _parentPool;
    [SerializeField] private int _poolSize = 20;


    private List<GameObject> _objectsInPool = new List<GameObject>();

    protected void InitializePool(GameObject prefab)
    {
        for (int i = 0; i < _poolSize; i++)
        {
            GameObject objectInPool = Instantiate(prefab, _parentPool.transform) as GameObject;
            objectInPool.SetActive(false);
            _objectsInPool.Add(objectInPool);
        }
    }

    protected bool TryGetObjectInPool(out GameObject result)
    {
        result = _objectsInPool.First(n => n.activeSelf == false);
        return result != null;
    } 
}
