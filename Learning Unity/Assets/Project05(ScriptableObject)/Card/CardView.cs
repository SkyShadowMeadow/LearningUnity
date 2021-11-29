using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    [SerializeField] private Card _card;
    [SerializeField] private Text _text; 

    void Start()
    {
        _text.text = "Name: " + _card.Name + "\n" + "Health: " + _card.Health.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
