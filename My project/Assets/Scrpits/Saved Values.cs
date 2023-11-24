using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavedValues : MonoBehaviour
{
    public int tempGelatin = 1000, tempGold = 500, quantityJellyValue = 1, touchJellyValue = 1;
    public int count = 0;
    public bool[] unlockArray = { true, true, false, false, false, false, false, false, false, false, false };
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            tempGelatin += 100000;
            tempGold += 5000;
        }
    }
}
