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

    void Awake()
    {
        assetArray = FindObjectOfType<AssetArray>();
        savedValues = FindObjectOfType<SavedValues>();

        quantityJellyText = quantityJelly.GetComponent<Text>();
        jelatinText = jelatin.GetComponent<Text>();
        upgradeQuantityText = upgradeQuantity.GetComponent<Text>();
        upgradeJelatinText = upgradeJelatin.GetComponent<Text>();
    }

    private void Start()
    {
        quantityJellyText.text = string.Format("Á©¸® ¼ö¿ë·® {0}", savedValues.quantityJellyValue);
        jelatinText.text = string.Format("Á©¶óÆ¾ »ý»ê x {0}", (savedValues.jelatinValue + 1));
        upgradeQuantityText.text = ChangeCommaText(savedValues.quantityJellyValue * 300);
        upgradeJelatinText.text = ChangeCommaText(savedValues.jelatinValue * 2000);
    }

    public void QuantityBtnClick()
    {
        if (savedValues.tempGold >= savedValues.quantityJellyValue * 300)
        {
            savedValues.tempGold -= savedValues.quantityJellyValue * 300;
            savedValues.quantityJellyValue++;
            quantityJellyText.text = string.Format("Á©¸® ¼ö¿ë·® {0}", savedValues.quantityJellyValue);
            upgradeQuantityText.text = ChangeCommaText(savedValues.quantityJellyValue * 300);
        }
    }

    public void JelatinBtnClick()
    {
        if (savedValues.tempGold >= savedValues.jelatinValue * 2000)
        {
            savedValues.tempGold -= savedValues.jelatinValue * 2000;
            savedValues.jelatinValue++;
            jelatinText.text = string.Format("Á©¶óÆ¾ »ý»ê x {0}", (savedValues.jelatinValue + 1));
            upgradeJelatinText.text = ChangeCommaText(savedValues.jelatinValue * 2000);
        }
    }

    string ChangeCommaText(float data)
    {
        return string.Format("{0:#,##0}", (int)data);
    }
}
