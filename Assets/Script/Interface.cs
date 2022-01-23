using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject card;
    //UI icons
    public Image mutluluk;
    public Image sehirlesme;
    public Image kırsal;
    public Image para;
    //UI impact icons
    public Image mutlulukImpact;
    public Image sehirlesmeImpact;
    public Image kırsalImpact;
    public Image paraImpact;
    void Update()
    {
        //UI icons
        mutluluk.fillAmount = (float)GameManager.instance.mutluluk / GameManager.instance.maxValue;
        sehirlesme.fillAmount = (float)GameManager.instance.sehirlesme / GameManager.instance.maxValue;
        kırsal.fillAmount = (float)GameManager.instance.kırsal / GameManager.instance.maxValue;
        para.fillAmount = (float)GameManager.instance.para / GameManager.instance.maxValue;

        //Right
        if(gameManager.direction == "right")
        {
            if(gameManager.currentCard.mutlulukRight!=0)
            mutlulukImpact.transform.localScale = new Vector3(1, 1, 0);
            if(gameManager.currentCard.sehirlesmeRight !=0)
            sehirlesmeImpact.transform.localScale = new Vector3(1, 1, 0);
            if (gameManager.currentCard.kırsalRight !=0)
            kırsalImpact.transform.localScale = new Vector3(1, 1, 0);
            if (gameManager.currentCard.paraRight !=0)
            paraImpact.transform.localScale = new Vector3(1, 1, 0);
        }
        //Left
        else if (gameManager.direction == "left")
        {
            if (gameManager.currentCard.mutlulukLeft != 0)
                mutlulukImpact.transform.localScale = new Vector3(1, 1, 0);
            if (gameManager.currentCard.sehirlesmeLeft != 0)
                sehirlesmeImpact.transform.localScale = new Vector3(1, 1, 0);
            if (gameManager.currentCard.kırsalLeft != 0)
                kırsalImpact.transform.localScale = new Vector3(1, 1, 0);
            if (gameManager.currentCard.paraLeft != 0)
                paraImpact.transform.localScale = new Vector3(1, 1, 0);
        }
        else
        {
            mutlulukImpact.transform.localScale = new Vector3(0, 0, 0);
            sehirlesmeImpact.transform.localScale = new Vector3(0, 0, 0);
            kırsalImpact.transform.localScale = new Vector3(0, 0, 0);
            paraImpact.transform.localScale = new Vector3(0, 0, 0);
        }
    }
}
