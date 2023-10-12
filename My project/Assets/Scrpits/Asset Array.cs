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
        for (int i = 0; i < koj.Length; i++)
        {
            koj[i] = new KindOfJelly
            {
                jellyName = $"Jelly {i}",
                sprite = Resources.Load<Sprite>($"Jelly {i}"),
            };
        }

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
}

public class AudioGroup
{
    public string audioName;
    public AudioClip audioClip;
}