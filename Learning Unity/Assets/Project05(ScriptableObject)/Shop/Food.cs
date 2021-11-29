using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Create new sword", menuName = "Goods/Food", order = 51)]

public class Food : Goods
{

        [SerializeField] protected int Calories;

        public override void ShowGoods()
        {
            Debug.Log($"Name : {Name} Description: {Description} Price: {Price} Calories {Calories}");
        }

    
}
