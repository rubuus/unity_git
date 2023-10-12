using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFX : MonoBehaviour
{
    AudioSource audioSource;
    public Slider sfxSlider;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        audioSource.volume = sfxSlider.value;
    }
}
