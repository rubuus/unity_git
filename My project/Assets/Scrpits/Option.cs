using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    public GameObject manager, sfx, optionPanel;
    AudioGroup[] sfxGroup;
    AudioSource audioSource;

    void Awake()
    {
        sfxGroup = manager.GetComponent<AssetArray>().audioGroup;
        audioSource = sfx.GetComponent<AudioSource>();
    }
    void Update()
    {
        if (!optionPanel.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                audioSource.clip = sfxGroup[5].audioClip;
                audioSource.Play();
                optionPanel.SetActive(true);
            }
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                optionPanel.SetActive(false);
            }
        }
    }
}
