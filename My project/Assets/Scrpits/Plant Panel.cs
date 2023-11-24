using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantPanel : MonoBehaviour
{
    public AssetArray assetArray;
    public SavedValues savedValues;
    public GameObject quantityJelly, touchJelly, upgradeQuantity, upgradeTouch;
    Text quantityJellyText, touchJellyText, upgradeQuantityText, upgradeTouchText;

    void Awake()
    {
        assetArray = FindObjectOfType<AssetArray>();
        savedValues = FindObjectOfType<SavedValues>();

        quantityJellyText = quantityJelly.GetComponent<Text>();
        touchJellyText = touchJelly.GetComponent<Text>();
        upgradeQuantityText = upgradeQuantityText.GetComponent<Text>();
        upgradeTouchText = upgradeTouchText.GetComponent<Text>();
    }

    void Update()
    {
        
    }

    public void QuantityBtnClick()
    {
        UpdateUI();
    }

    public void TouchBtnClick()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        
    }
}
