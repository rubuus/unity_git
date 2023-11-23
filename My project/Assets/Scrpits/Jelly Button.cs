using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyButton : MonoBehaviour
{
    public bool jellyIsOpened = false;

    public GameObject jellyPanel, plantPanel, optionPanel;
    Animator jellyAnim;

    void Awake()
    {
        jellyAnim = jellyPanel.GetComponent<Animator>();
    }

    void Update()
    {
        /*if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                jellyAnim.SetTrigger("doShow");
            }
        }*/
        
        if (Input.GetKeyDown(KeyCode.Escape) && jellyIsOpened)
        {
            jellyAnim.SetTrigger("doHide");
            jellyIsOpened = false;
        }
    }

    public void OnClick()
    {
        PanelView();
    }

    public void PanelView()
    {
        jellyAnim.SetTrigger("doShow");
        jellyIsOpened = true;
    }
}
