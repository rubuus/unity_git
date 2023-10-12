using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFX : MonoBehaviour
{
    GameObject sfx;

    AudioSource audioSource;
    Slider sfxSlider;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        sfx = GameObject.Find("SFX Slider");
        sfxSlider = sfx.GetComponent<Slider>();
    }
    void Update()
    {
        audioSource.volume = sfxSlider.value;
    }
}
