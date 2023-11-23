using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JellyPanelText : MonoBehaviour
{
    Text text;
    public GameObject jellyPanel;
    void Awake()
    {
        text = GetComponent<Text>();
    }

    void LateUpdate()
    {
        
    }
}
