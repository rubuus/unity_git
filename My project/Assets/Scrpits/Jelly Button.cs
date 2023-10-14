using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyButton : MonoBehaviour
{
    bool jellyIsOpened = false;

    public GameObject jellyPanel;
    Animator anim;

    void Awake()
    {
        anim = jellyPanel.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                anim.SetTrigger("doShow");
            }
        }

        if (!jellyIsOpened)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                anim.SetTrigger("doShow");
                jellyIsOpened = true;
            }
        }
        
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                anim.SetTrigger("doHide");
                jellyIsOpened = false;
            }
        }
    }
}
