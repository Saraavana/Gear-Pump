using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleRenderer : MonoBehaviour
{

    bool objectVisibility;
    void Start()
    {
        objectVisibility = false;
        gameObject.SetActive(objectVisibility);
    }

    public void ToggleVisibility()
    {

        if (objectVisibility == false)
            gameObject.SetActive(true);
        
        if (objectVisibility==false) 
        {
            gameObject.SetActive(true);
            objectVisibility = true;
        }    
        else
        {
            gameObject.SetActive(false);
            objectVisibility = false;
        }
    }

    public void showView()
    {
        gameObject.SetActive(true);
    }

}
