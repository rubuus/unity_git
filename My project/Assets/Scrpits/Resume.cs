using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject parent, manager, sfx;
    AudioGroup[] sfxGroup;
    AudioSource audioSource;

    void Awake()
    {
        sfxGroup = manager.GetComponent<AssetArray>().audioGroup;
        audioSource = sfx.GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                audioSource.clip = sfxGroup[6].audioClip;
                audioSource.Play();
                parent.SetActive(false);
            }
        }
    }
}
