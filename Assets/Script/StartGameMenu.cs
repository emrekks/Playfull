using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            SoundManager.instance.mouseClick.Play();
        }
    }
    public void changeSceneToGameScreen()
    {
        SceneManager.LoadScene("SampleScene");
        SoundManager.instance.OyunAcilis.Play();
    }
    public void OnClickQuitButton()
    {
        Application.Quit();
    }
}
