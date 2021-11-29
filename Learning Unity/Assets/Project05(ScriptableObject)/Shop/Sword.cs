using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Create new sword", menuName = "Goods/Sword", order = 51)]
public class Sword : Goods
{
    [SerializeField] protected int Damage;
    
    public override void ShowGoods()
    {
        Debug.Log($"Name : {Name} Description: {Description} Price: {Price} Damage {Damage}");
    }

}
