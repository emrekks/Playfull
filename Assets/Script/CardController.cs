using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public Card card;
    BoxCollider2D thisCard;
    public bool isMouseOver;
    // Start is called before the first frame update
    void Start()
    {
        thisCard = gameObject.GetComponent<BoxCollider2D>();
    }
    private void OnMouseOver()
    {
        isMouseOver = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
    }
}

public enum CardSprite
{
    AS,
    K7  
}