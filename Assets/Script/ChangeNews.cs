using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNews : MonoBehaviour
{
    public Sprite MutlulukAz;
    public Sprite MutlulukCok;
    public Sprite SehirlesmeAz;
    public Sprite SehirlesmeCok;
    public Sprite DogaCok;
    public Sprite DogaAz;
    public Sprite ParaCok;
    public Sprite ParaAz;

    public Image Photo1;
    public Image Photo2;
    public Image Photo3;
    public Image Photo4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.mutluluk < 50)
        {
            Photo1.sprite = MutlulukAz;
        }
        else
        {
            Photo1.sprite = MutlulukCok;
        }
        
        if (GameManager.sehirlesme < 50)
        {
            Photo2.sprite = SehirlesmeAz;
        }
        else
        {
            Photo2.sprite = SehirlesmeCok;
        }
       
        if (GameManager.kırsal < 50)
        {
            Photo3.sprite = DogaCok;
        }
        else
        {
            Photo3.sprite = DogaAz;
        }
       
        if (GameManager.para < 50)
        {
            Photo4.sprite = ParaCok;
        }
        else
        {
            Photo4.sprite = ParaAz;
        }
    }
}
