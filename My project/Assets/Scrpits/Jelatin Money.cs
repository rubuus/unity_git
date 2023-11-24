using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JelatinMoney : MonoBehaviour
{
    int curretMoney, targetMoney;
    bool isCountingUp = false;

    Text txt;
    public GameObject gameManager;

    void Awake()
    {
        curretMoney = 1000;
        targetMoney = gameManager.GetComponent<SavedValues>().tempGelatin;
        txt = GetComponent<Text>();
        txt.text = ChangeCommaText(curretMoney);
    }

    void Update()
    {
        targetMoney = gameManager.GetComponent<SavedValues>().tempGelatin;

        if (curretMoney != targetMoney && !isCountingUp)
        {
            StartCoroutine(CountUpMoney(curretMoney, targetMoney));
        }
    }

    IEnumerator CountUpMoney(int startMoney, int endMoney)
    {
        isCountingUp = true;
        float elapsedTime = 0;

        while (elapsedTime < 0.4f)
        {
            elapsedTime += Time.deltaTime;
            curretMoney = (int)Mathf.Lerp(startMoney, endMoney, elapsedTime);
            txt.text = ChangeCommaText(curretMoney);
            yield return null;
        }

        curretMoney = endMoney;
        txt.text = ChangeCommaText(curretMoney);

        isCountingUp = false;
    }

    string ChangeCommaText(float data)
    {
        return string.Format("{0:#,##0}", (int)data);
    }
}
