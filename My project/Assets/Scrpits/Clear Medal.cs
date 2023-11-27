using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearMedal : MonoBehaviour
{
    public SavedValues savedValues;
    void Update()
    {
        if (savedValues.isClear)
        {
            gameObject.SetActive(true);
        }
    }
}
