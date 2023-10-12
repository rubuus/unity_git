using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGM : MonoBehaviour
{
    GameObject bgm;

    AudioSource audioSource;
    Slider bgmSlider;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        bgm = GameObject.Find("BGM Slider");
        bgmSlider = bgm.GetComponent<Slider>();
    }
    void Update()
    {
        audioSource.volume = bgmSlider.value;
    }
}
