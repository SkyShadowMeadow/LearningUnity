using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class Goods : ScriptableObject
{
    [SerializeField] protected string Name;
    [SerializeField] protected string Description;
    [SerializeField] protected int Price;

    public abstract void ShowGoods();
    
}
