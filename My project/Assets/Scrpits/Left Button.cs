using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour
{
    public bool jellyIsOpened, plantIsOpened;

    public GameObject jellyPanel, plantPanel, optionPanel;
    Animator jellyAnim, plantAnim;
    void Awake()
    {
        jellyAnim = jellyPanel.GetComponent<Animator>();
        plantAnim = plantPanel.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && jellyIsOpened)
        {
            jellyAnim.SetTrigger("doHide");
            jellyIsOpened = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && plantIsOpened)
        {
            plantAnim.SetTrigger("doHide");
            plantIsOpened = false;
        }
    }

    public void JellyPanelVisible()
    {
        if (jellyIsOpened == false && plantIsOpened == false)
        {
            jellyAnim.SetTrigger("doShow");
            jellyIsOpened = true;
            Debug.Log(jellyIsOpened);
        }
    }

    private void JellyPanelInvisible()
    {
        jellyAnim.SetTrigger("doHide");
        jellyIsOpened = false;
    }

    public void PlantPanelVisible()
    {
        if (plantIsOpened == false && jellyIsOpened == false)
        {
            plantAnim.SetTrigger("doShow");
            plantIsOpened = true;
        }
    }

    private void PlantPanelInvisible()
    {
        plantAnim.SetTrigger("doHide");
        plantIsOpened = false;
    }
}
