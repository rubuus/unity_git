using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    int money;

    Text text;
    public GameObject jelly;

    void Start()
    {
        money = jelly.GetComponent<Jelly>().tempGelatin;
        text = GetComponent<Text>();
        
        text.text = money.ToString();
    }

    void LateUpdate()
    {
        money = jelly.GetComponent<Jelly>().tempGelatin;
        text.text = money.ToString();
    }
}
