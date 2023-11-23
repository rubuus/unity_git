using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AssetArray : MonoBehaviour
{
    public KindOfJelly[] koj = new KindOfJelly[12];
    public AudioGroup[] audioGroup = new AudioGroup[10];
    void Awake()
    {
        koj[0] = new KindOfJelly
        {
            jellyName = "½½¶óÀÓ",
            sprite = Resources.Load<Sprite>("Jelly 0"),
            price = 100
        };

        koj[1] = new KindOfJelly
        {
            jellyName = "Á©¸®ºó",
            sprite = Resources.Load<Sprite>("Jelly 1"),
            price = 200
        };

        koj[2] = new KindOfJelly
        {
            jellyName = "Æ÷µµ",
            sprite = Resources.Load<Sprite>("Jelly 2"),
            price = 500
        };

        koj[3] = new KindOfJelly
        {
            jellyName = "°õµ¹ÀÌ",
            sprite = Resources.Load<Sprite>("Jelly 3"),
            price = 1000
        };

        koj[4] = new KindOfJelly
        {
            jellyName = "Çªµù",
            sprite = Resources.Load<Sprite>("Jelly 4"),
            price = 1500
        };

        koj[5] = new KindOfJelly
        {
            jellyName = "¾ç°»",
            sprite = Resources.Load<Sprite>("Jelly 5"),
            price = 2000
        };

        koj[6] = new KindOfJelly
        {
            jellyName = "³É¹ß¹Ù´Ú",
            sprite = Resources.Load<Sprite>("Jelly 6"),
            price = 3000
        };

        koj[7] = new KindOfJelly
        {
            jellyName = "²ÞÆ²ÀÌ",
            sprite = Resources.Load<Sprite>("Jelly 7"),
            price = 5000
        };

        koj[8] = new KindOfJelly
        {
            jellyName = "»ó¾î",
            sprite = Resources.Load<Sprite>("Jelly 8"),
            price = 7500
        };

        koj[9] = new KindOfJelly
        {
            jellyName = "ÃÊ¹ä",
            sprite = Resources.Load<Sprite>("Jelly 9"),
            price = 10000
        };

        koj[10] = new KindOfJelly
        {
            jellyName = "·Î¾â",
            sprite = Resources.Load<Sprite>("Jelly 10"),
            price = 25000
        };

        koj[11] = new KindOfJelly
        {
            jellyName = "Áö±¸",
            sprite = Resources.Load<Sprite>("Jelly 11"),
            price = 50000
        };

        audioGroup[0] = new AudioGroup
        {
            audioName = "Button",
            audioClip = Resources.Load<AudioClip>("Button")
        };

        audioGroup[1] = new AudioGroup
        {
            audioName = "Buy",
            audioClip = Resources.Load<AudioClip>("Buy")
        };

        audioGroup[2] = new AudioGroup
        {
            audioName = "Clear",
            audioClip = Resources.Load<AudioClip>("Clear")
        };

        audioGroup[3] = new AudioGroup
        {
            audioName = "Fail",
            audioClip = Resources.Load<AudioClip>("Fail")
        };

        audioGroup[4] = new AudioGroup
        {
            audioName = "Grow",
            audioClip = Resources.Load<AudioClip>("Grow")
        };

        audioGroup[5] = new AudioGroup
        {
            audioName = "Parse In",
            audioClip = Resources.Load<AudioClip>("Pause In")
        };

        audioGroup[6] = new AudioGroup
        {
            audioName = "Parse Out",
            audioClip = Resources.Load<AudioClip>("Pause Out")
        };

        audioGroup[7] = new AudioGroup
        {
            audioName = "Sell",
            audioClip = Resources.Load<AudioClip>("Sell")
        };

        audioGroup[8] = new AudioGroup
        {
            audioName = "Touch",
            audioClip = Resources.Load<AudioClip>("Touch")
        };

        audioGroup[9] = new AudioGroup
        {
            audioName = "Unlock",
            audioClip = Resources.Load<AudioClip>("Unlock")
        };
    }
}

public class KindOfJelly
{
    public string jellyName;
    public Sprite sprite;
    public int price;
}

public class AudioGroup
{
    public string audioName;
    public AudioClip audioClip;
}