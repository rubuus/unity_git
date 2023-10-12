using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    GameObject parent;

    void Awake()
    {
        parent = GameObject.Find("Option Panel");
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                parent.SetActive(false);
            }
        }
    }
}
