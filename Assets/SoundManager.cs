using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    #region Singleton


    public static SoundManager instance;
    public void Awake()
    {
        instance = this;
    }

    #endregion

    public AudioSource mailKaydirma;
    public AudioSource mouseClick;
    public AudioSource sekmeGecis;
    public AudioSource OyunAcilis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
