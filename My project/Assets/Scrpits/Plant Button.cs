using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantButton : MonoBehaviour
{
    public bool plantIsOpened = false;

    public GameObject plantPanel, jellyPanel, optionPanel;
    Animator plantAnim;

    void Awake()
    {
        plantAnim = plantPanel.GetComponent<Animator>();
    }

    void Update()
    {
        /*if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                anim.SetTrigger("doShow");
            }
        }*/

        if (Input.GetKeyDown(KeyCode.A) && !plantIsOpened)
        {
            JellyButton jellyButtonScript = jellyPanel.GetComponent<JellyButton>();

            if (!(jellyButtonScript.jellyIsOpened || optionPanel.activeSelf))
            {
                plantAnim.SetTrigger("doShow");
                plantIsOpened = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape) && plantIsOpened)
        {
            plantAnim.SetTrigger("doHide");
            plantIsOpened = false;  
        }
    }
}
