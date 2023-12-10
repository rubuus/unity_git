using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantPanel : MonoBehaviour
{
    public AssetArray assetArray;
    public SavedValues savedValues;
    public GameObject quantityJelly, jelatin, upgradeQuantity, upgradeJelatin;
    Text quantityJellyText, jelatinText, upgradeQuantityText, upgradeJelatinText;

    private void Start()
    {
        assetArray = FindObjectOfType<AssetArray>();
        savedValues = FindObjectOfType<SavedValues>();

        quantityJellyText = quantityJelly.GetComponent<Text>();
        jelatinText = jelatin.GetComponent<Text>();
        upgradeQuantityText = upgradeQuantity.GetComponent<Text>();
        upgradeJelatinText = upgradeJelatin.GetComponent<Text>();
    }

    void Update()
    {
        quantityJellyText.text = string.Format("���� ���뷮 {0}", savedValues.quantityJellyValue);
        jelatinText.text = string.Format("����ƾ ���� x {0}", savedValues.jelatinValue);
        upgradeQuantityText.text = ChangeCommaText(savedValues.quantityJellyValue * 300);
        upgradeJelatinText.text = ChangeCommaText(savedValues.jelatinValue * 500);
    }

    public void QuantityBtnClick()
    {
        if (savedValues.tempGold >= savedValues.quantityJellyValue * 300)
        {
            savedValues.tempGold -= savedValues.quantityJellyValue * 300;
            savedValues.quantityJellyValue++;
        }
    }

    public void JelatinBtnClick()
    {
        if (savedValues.tempGold >= savedValues.jelatinValue * 500)
        {
            savedValues.tempGold -= savedValues.jelatinValue * 500;
            savedValues.jelatinValue++;
        }
    }

    string ChangeCommaText(float data)
    {
        return string.Format("{0:#,##0}", (int)data);
    }
}
