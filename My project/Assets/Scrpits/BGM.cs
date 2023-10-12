using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGM : MonoBehaviour
{
    AudioSource audioSource;
    public Slider bgmSlider;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        audioSource.volume = bgmSlider.value;
    }
}
