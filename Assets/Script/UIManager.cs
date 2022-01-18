﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("UI Variables")] 
    public GameObject uiIcons;
    public GameObject gameScene;
    public GameObject newsScene;
    public GameObject emailButtonObject;
    public GameObject newsButtonObject;
    public GameObject volumeOff;
    public GameObject volumeOn;
    //PrivateVariables
    private Image emailImage;
    private Button emailButton;
    private Image newsImage;
    private Button newsButton;
    private bool volumeBoolOn = true;

    private void Start()
    {
        emailImage = emailButtonObject.GetComponent<Image>();
        emailButton = emailButtonObject.GetComponent<Button>();
        newsImage = newsButtonObject.GetComponent<Image>();
        newsButton = newsButtonObject.GetComponent<Button>();
        emailImage.color = emailButton.colors.pressedColor;
        newsScene.SetActive(false);
        volumeOff.SetActive(false);
    }

    public void OnClickNews()
    {
        uiIcons.SetActive(false);
        gameScene.SetActive(false);
        newsScene.SetActive(true);
        emailImage.color = emailButton.colors.normalColor;
        newsImage.color = newsButton.colors.pressedColor;
    }
    
    public void OnClickEmail()
    {
        uiIcons.SetActive(true);
        gameScene.SetActive(true);
        newsScene.SetActive(false);
        emailImage.color = emailButton.colors.pressedColor;
        newsImage.color = newsButton.colors.normalColor;
    }

    public void OnClickQuitButton()
    {
        Application.Quit();
    }

    public void MuteSound()
    {
        if (volumeBoolOn == true)
        {
            volumeOff.SetActive(true);
            volumeOn.SetActive(false);
            volumeBoolOn = false;
        }
        else
        {
            volumeOff.SetActive(false);
            volumeOn.SetActive(true);
            volumeBoolOn = true;
        }
    }


}
