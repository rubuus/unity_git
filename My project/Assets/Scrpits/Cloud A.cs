using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CloudA : MonoBehaviour
{
    float speed = 0.1f;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (transform.position.x > 8)
            transform.position = new Vector3(-8, 3, 0);
        else
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        
        
    }
}
