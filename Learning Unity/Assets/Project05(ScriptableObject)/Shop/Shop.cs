using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private Goods[] _goods;

    private void Start()
    {
        foreach (Goods item in _goods)
        {
            item.ShowGoods();
        }
    }
}
