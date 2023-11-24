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
        upgradeQuantityText = upgradeQuantity.GetComponent<Text>();
        upgradeTouchText = upgradeTouch.GetComponent<Text>();
    }

    private void Start()
    {
        quantityJellyText.text = string.Format("젤리 수용량 {0}", savedValues.quantityJellyValue);
        touchJellyText.text = string.Format("클릭 생산량 x {0}", savedValues.touchJellyValue);
        upgradeQuantityText.text = ChangeCommaText(savedValues.quantityJellyValue * 3000);
        upgradeTouchText.text = ChangeCommaText(savedValues.touchJellyValue * 3000);
    }

    public void QuantityBtnClick()
    {
        if (savedValues.tempGold >= savedValues.quantityJellyValue * 3000)
        {
            savedValues.tempGold -= savedValues.quantityJellyValue * 3000;
            savedValues.quantityJellyValue++;
            quantityJellyText.text = string.Format("젤리 수용량 {0}", savedValues.quantityJellyValue);
            upgradeQuantityText.text = ChangeCommaText(savedValues.quantityJellyValue * 3000);
        }
    }

    public void TouchBtnClick()
    {
        if (savedValues.tempGold >= savedValues.touchJellyValue * 3000)
        {
            savedValues.tempGold -= savedValues.touchJellyValue * 3000;
            savedValues.touchJellyValue++;
            touchJellyText.text = string.Format("클릭 생산량 x {0}", savedValues.touchJellyValue);
            upgradeTouchText.text = ChangeCommaText(savedValues.touchJellyValue * 3000);
        }
    }

    string ChangeCommaText(float data)
    {
        return string.Format("{0:#,##0}", (int)data);
    }
}
