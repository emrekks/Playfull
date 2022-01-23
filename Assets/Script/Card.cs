using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Card : ScriptableObject
{
    public int cardID;
    public string cardName;
    public CardSprite sprite;
    public string dialogue;
    public string leftQuote;
    public string rightQuote;
    //Game icon Variables
    //Left
    public int mutlulukLeft;
    public int sehirlesmeLeft;
    public int kırsalLeft;
    public int paraLeft;
    //Right
    public int mutlulukRight;
    public int sehirlesmeRight;
    public int kırsalRight;
    public int paraRight;
    public void Left()
        {
        Debug.Log(cardName + " swiped left");
        GameManager.instance.mutluluk += mutlulukLeft;
        GameManager.instance.sehirlesme += sehirlesmeLeft;
        GameManager.instance.kırsal += kırsalLeft;
        GameManager.instance.para += paraLeft;
        }

        public void Right()
        {
        Debug.Log(cardName + " swiped right");
        GameManager.instance.mutluluk += mutlulukRight;
        GameManager.instance.sehirlesme += sehirlesmeRight;
        GameManager.instance.kırsal += kırsalRight;
        GameManager.instance.para += paraRight;
        }

}
