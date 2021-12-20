using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Gameobjects
    public GameObject cardGameObject;
    public CardController mainCardController;
    public SpriteRenderer cardSpriteRenderer;
    public SpriteRenderer cardColorSpriteRenderer;
    public ResourceManager resourceManagers;
    //Tweaking variables
    public float fMovingSpeed;
    public float fSideMargin;
    public float fSideTrigger;
    public float divideValue;
    float alphaText;
    Color textColor;
    Vector3 pos;
    //UI
    public TMP_Text display;
    public TMP_Text characterName;
    public TMP_Text dialogue;
    //Card Variables
    private string leftQuote;
    private string rightQuote;
    public Card currentCard;
    public Card testCard;

    void Start()
    {
        LoadCard(testCard);
    }

    void UpdateDialogue()
    {
        dialogue.color = textColor;
        if (cardGameObject.transform.position.x < 0)
        {
            dialogue.text = leftQuote;
            if(cardGameObject.transform.position.x < -1)
            {
                cardColorSpriteRenderer.color = Color.red;
            }
            else
            {
                {
                    cardColorSpriteRenderer.color = Color.white;
                }
            }

        }
        else if(cardGameObject.transform.position.x > 0)
        {
            dialogue.text = rightQuote;
            if (cardGameObject.transform.position.x > 1)
            {
                cardColorSpriteRenderer.color = Color.green;

            }
            else
            {
                {
                    cardColorSpriteRenderer.color = Color.white;
                }
            }
        }
        else
        {
            {
                cardColorSpriteRenderer.color = Color.white;
            }
        }

    }

    void Update()
    {
        //Dialogue text handing
        textColor.a = Mathf.Min((Mathf.Abs(cardGameObject.transform.position.x) - fSideMargin) / divideValue, 1);
        if (cardGameObject.transform.position.x > fSideTrigger)
        {
            if (Input.GetMouseButtonUp(0))
            {
                currentCard.Right();
            }
        }

        else if(cardGameObject.transform.position.x > fSideMargin)
        {
        }

        else if (cardGameObject.transform.position.x > -fSideMargin)
        {
            textColor.a = 0;
        }

        else if (cardGameObject.transform.position.x > -fSideTrigger)
        {
        }

        else
        {
            if (Input.GetMouseButtonUp(0))
            {
                currentCard.Left();
            }
        }
       
        UpdateDialogue();

        //Movement
        if (Input.GetMouseButton(0) && mainCardController.isMouseOver) 
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            cardGameObject.transform.position = pos;
        }
        else
        {
            cardGameObject.transform.position = Vector2.MoveTowards(cardGameObject.transform.position, new Vector2(0, 0), fMovingSpeed);
        }
        //UI
        display.text = "" + textColor.a;
    }

    public void LoadCard(Card card)
    {
        cardSpriteRenderer.sprite = resourceManagers.sprites[(int)card.sprite];
        leftQuote = card.leftQuote;
        rightQuote = card.rightQuote;
        currentCard = card;
    }
}
