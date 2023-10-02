using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public int money = 1000;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        
        text.text = money.ToString();
    }

    void LateUpdate()
    {

    }
}
