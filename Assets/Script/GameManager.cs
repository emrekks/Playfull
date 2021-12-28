using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Game icon Variables
    public static int mutluluk =50;
    public static int sehirlesme = 50;
    public static int kırsal = 50;
    public static int para = 50;
    public static int maxValue = 100;
    public int minValue = 0;
    //Gameobjects
    public GameObject cardGameObject;
    public CardController mainCardController;
    public SpriteRenderer cardSpriteRenderer;
    public SpriteRenderer cardColorSpriteRenderer;
    public ResourceManager resourceManagers;
    public Vector2 defaultPositionCard;
    public Vector3 cardRotation;
    //Tweaking variables
    public float fMovingSpeed;
    public float fSideMargin;
    public float fSideTrigger;
    public float divideValue;
    public float fRotationCoefficent;
    float alphaText;
    Color textColor;
    Vector3 pos;
    //UI
    public TMP_Text display;
    public TMP_Text characterDialogue;
    public TMP_Text actionQuote;
    //Card Variables
    public string direction;
    private string leftQuote;
    private string rightQuote;
    public Card currentCard;
    public Card testCard;
    public int cardNumber = 0;

    void Start()
    {
        LoadCard(testCard);
    }

    void UpdateDialogue()
    {
        actionQuote.color = textColor;
        if (cardGameObject.transform.position.x < 0)
        {
            actionQuote.text = leftQuote;
            if(cardGameObject.transform.position.x < -1)
            {
                cardColorSpriteRenderer.color = Color.red;
            }
            else
            {
                {
                    cardColorSpriteRenderer.color = Color.gray;
                }
            }

        }
        else if(cardGameObject.transform.position.x > 0)
        {
            actionQuote.text = rightQuote;
            if (cardGameObject.transform.position.x > 1)
            {
                cardColorSpriteRenderer.color = Color.green;

            }
            else
            {
                {
                    cardColorSpriteRenderer.color = Color.gray;
                }
            }
        }
        else
        {
            {
                cardColorSpriteRenderer.color = Color.gray;
            }
        }

    }

    void Update()
    {
        //Dialogue text handing
        textColor.a = Mathf.Min((Mathf.Abs(cardGameObject.transform.position.x) - fSideMargin) / divideValue, 1);
        if (cardGameObject.transform.position.x > fSideTrigger)
        {
            direction = "right";
            if (Input.GetMouseButtonUp(0))
            {
                currentCard.Right();
                NewCard();
            }
        }

        else if(cardGameObject.transform.position.x > fSideMargin)
        {
            direction = "right";
        }

        else if (cardGameObject.transform.position.x > -fSideMargin)
        {
            direction = "none";
            textColor.a = 0;
        }

        else if (cardGameObject.transform.position.x > -fSideTrigger)
        {
            direction = "left";
        }

        else
        {
            direction = "left";
            if (Input.GetMouseButtonUp(0))
            {
                currentCard.Left();
                NewCard();
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
            cardGameObject.transform.position = Vector2.MoveTowards(cardGameObject.transform.position, defaultPositionCard, fMovingSpeed);
            cardGameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        //UI
        display.text = "" + textColor.a;
        
        //Rotating The Card
        cardGameObject.transform.eulerAngles = new Vector3(0, 0, cardGameObject.transform.position.x * fRotationCoefficent);
    }

    public void LoadCard(Card card)
    {
        cardSpriteRenderer.sprite = resourceManagers.sprites[(int)card.sprite];
        leftQuote = card.leftQuote;
        rightQuote = card.rightQuote;
        currentCard = card;
        characterDialogue.text = card.dialogue;
    }

    public void NewCard()
    {
        cardNumber++;
        LoadCard(resourceManagers.cards[0]);
    }
}
