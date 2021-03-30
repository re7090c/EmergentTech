﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject Menu;
    // Start is called before the first frame update
    void Start()
    {
        Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openMenu()
    {
        if (Menu.activeSelf)
        {
            Menu.SetActive(false);

        }
        else
        {
            Menu.SetActive(true);
        }
    }

  
}
