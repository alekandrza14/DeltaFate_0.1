﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class button144 : MonoBehaviour
{

    public int id;
    private void Start()
    {
        
    }
    private void OnTriggerStay2D(Collider2D s)
    {
        if (s.gameObject.tag == "Player")
        {
            if (PlayerPrefs.GetFloat("attack",0) >= 1500)
            {
                PlayerPrefs.SetInt("u",id);
            }

        }
    }
}

