using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantButton : MonoBehaviour
{
    bool plantIsOpened = false;

    public GameObject plantPanel;
    Animator anim;

    void Awake()
    {
        anim = plantPanel.GetComponent<Animator>();
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

        if (!plantIsOpened)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                anim.SetTrigger("doShow");
                plantIsOpened = true;
            }
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                anim.SetTrigger("doHide");
                plantIsOpened = false;
            }
        }
    }
}
