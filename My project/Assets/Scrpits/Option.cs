using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    GameObject resume, exit;

    void Awake()
    {
        resume = GameObject.Find("Resume Button").gameObject;
        exit = GameObject.Find ("Exit Button").gameObject;
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            gameObject.SetActive(true);
        }
    }
}
