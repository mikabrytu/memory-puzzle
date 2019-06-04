using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    
    public Card card;

    private GridController grid;
    private SpriteRenderer renderer;
    private Sprite cardSprite;

    void Start()
    {
        grid = GetComponentInParent<GridController>();
        
        renderer = GetComponent<SpriteRenderer>();
        cardSprite = renderer.sprite;
    }

    void OnMouseDown() 
    {
        renderer.sprite = card.GetSprite();
        //grid.CheckCard(card);
    }

    public void ResetCard()
    {
        renderer.sprite = cardSprite;
    }

}
