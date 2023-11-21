using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    public GameObject manager, sfx, optionPanel, jellyPanel, plantPanel;
    AudioGroup[] sfxGroup;
    AudioSource audioSource;

    bool a = false;

    void Awake()
    {
        sfxGroup = manager.GetComponent<AssetArray>().audioGroup;
        audioSource = sfx.GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            JellyButton jellyButtonScript = jellyPanel.GetComponent<JellyButton>();
            PlantButton plantButtonScript = plantPanel.GetComponent<PlantButton>();

            if (!(jellyButtonScript.jellyIsOpened || plantButtonScript.plantIsOpened))
            {
                if (optionPanel.activeSelf)
                {
                    optionPanel.SetActive(false);
                }
                else
                {
                    audioSource.clip = sfxGroup[5].audioClip;
                    audioSource.Play();
                    optionPanel.SetActive(true);
                }
            }
        }
    }

}
