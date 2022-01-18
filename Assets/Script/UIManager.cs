using System;
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
    //PrivateVariables
    private Image emailImage;
    private Button emailButton;
    private Image newsImage;
    private Button newsButton;

    private void Start()
    {
        emailImage = emailButtonObject.GetComponent<Image>();
        emailButton = emailButtonObject.GetComponent<Button>();
        newsImage = newsButtonObject.GetComponent<Image>();
        newsButton = newsButtonObject.GetComponent<Button>();
        emailImage.color = emailButton.colors.pressedColor;
        newsScene.SetActive(false);
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
    
    
}
