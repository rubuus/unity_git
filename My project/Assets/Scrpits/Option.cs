using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    public GameObject manager, sfx, optionPanel, leftBtn;

    public bool jellyAlive, plantAlive;

    AudioGroup[] sfxGroup;
    AudioSource audioSource;

    void Awake()
    {
        sfxGroup = manager.GetComponent<AssetArray>().audioGroup;
        audioSource = sfx.GetComponent<AudioSource>();

        jellyAlive = leftBtn.GetComponent<LeftButton>().jellyIsOpened;
        plantAlive = leftBtn.GetComponent<LeftButton>().plantIsOpened;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !optionPanel.activeSelf)
        {
            if (!(jellyAlive || plantAlive))
            {
                audioSource.clip = sfxGroup[5].audioClip;
                audioSource.Play();
                optionPanel.SetActive(true);
            }
                
        }

        else if (Input.GetKeyDown(KeyCode.K) && optionPanel.activeSelf)
        {
            optionPanel.SetActive(false);
        }
    }

}
