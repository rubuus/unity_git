using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class SavedValues : MonoBehaviour
{
    public int tempGelatin = 1000, tempGold = 500, quantityJellyValue = 1, jelatinValue = 1;
    public int count = 0, idTotal = 0, quantity = 0;
    public bool isClear = false;
    public bool[] unlockArray = { true, true, false, false, false, false, false, false, false, false, false, false};
    public GameObject prefabToInstantiate;
    public List<int> jellyID = new List<int>();

    void Start()
    {
        LoadPlayerData();
        InvokeRepeating("PlusGelatin", 2f, 2f);
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                tempGold += idTotal;
            }
        }

        if (!ClearCheck(unlockArray, false))
        {
            isClear = true;
        }
    }

    void PlusGelatin()
    {
        tempGelatin += (50 * jelatinValue);
    }

    bool ClearCheck(bool[] array, bool target)
    {
        return array.Contains(target);
    }

    void SavePlayerData()
    {
        PlayerPrefs.SetInt("Gelatin", tempGelatin);
        PlayerPrefs.SetInt("Gold", tempGold);
        PlayerPrefs.SetInt("quantityJellyValue", quantityJellyValue);
        PlayerPrefs.SetInt("jelatinValue", jelatinValue);
        PlayerPrefs.SetInt("idTotal", idTotal);
        PlayerPrefs.SetInt("quantity", quantity);
        PlayerPrefs.SetString("Clear", isClear.ToString());
        PlayerPrefs.SetString("unlockArray", SaveArray(unlockArray));
        PlayerPrefs.SetString("jellyID", SaveList(jellyID));
        PlayerPrefs.Save();
    }

    string SaveArray(bool[] array)
    {
        string str = "";

        for (int i = 0; i < array.Length; i++)
        {
            str += array[i].ToString();

            if (i < array.Length - 1)
            {
                str += ",";
            }
        }

        return str;
    }

    string SaveList(List<int> list)
    {
        string str = "";

        for (int i = 0; i < list.Count; i++)
        {
            str += list[i];

            if (i < list.Count - 1)
            {
                str += ",";
            }
        }
        
        return str;
    }

    void LoadPlayerData()
    {
        tempGelatin = PlayerPrefs.GetInt("Gelatin");
        tempGold = PlayerPrefs.GetInt("Gold");
        quantityJellyValue = PlayerPrefs.GetInt("quantityJellyValue");
        jelatinValue = PlayerPrefs.GetInt("jelatinValue");
        idTotal = PlayerPrefs.GetInt("idTotal");
        quantity = PlayerPrefs.GetInt("quantity");
        isClear = bool.Parse(PlayerPrefs.GetString("Clear"));
        unlockArray = LoadUnlockArray();
        jellyID = LoadJellyID();
        LoadJellyObj(jellyID);
    }

    bool[] LoadUnlockArray()
    {
        string[] dataArr = PlayerPrefs.GetString("unlockArray").Split(',');

        bool[] array = new bool[dataArr.Length];

        for (int i = 0; i < dataArr.Length; i++)
        {
            if (dataArr[i].ToLower() == "true")
            {
                array[i] = true;
            }
            else if (dataArr[i].ToLower() == "false")
            {
                array[i] = false;
            }
            else
            {
                array[i] = false;
            }
        }

        return array;
    }

    List<int> LoadJellyID()
    {
        string[] dataArr = PlayerPrefs.GetString("jellyID").Split(',');

        List<int> numbers = new List<int>();

        for (int i = 0; i < dataArr.Length; i++)
        {
            numbers.Add(int.Parse(dataArr[i]));
        }

        return numbers;
    }

    void LoadJellyObj(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            GameObject spawedPrefab = Instantiate(prefabToInstantiate, transform.position, Quaternion.identity);
            Jelly jellyScript = spawedPrefab.GetComponent<Jelly>();
            jellyScript.ID = list[i];
        }
    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }

    void OnApplicationQuit()
    {
        SavePlayerData();
    }
}
