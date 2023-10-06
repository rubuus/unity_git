using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    int money;

    Text text;
    GameObject jelly;

    void Start()
    {
        jelly = GameObject.Find("Jelly");
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
