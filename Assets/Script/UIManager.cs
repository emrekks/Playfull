using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("UI Variables")] 
    public GameObject uiIcons;
    public GameObject gameScene;
    
    
    
    public void OnClickNews()
    {
        uiIcons.SetActive(false);
        gameScene.SetActive(false);
    }
    
    public void OnClickEmail()
    {
        uiIcons.SetActive(true);
        gameScene.SetActive(true);
    }
}
