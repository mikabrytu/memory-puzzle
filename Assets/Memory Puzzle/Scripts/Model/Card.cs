using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{

    private int id;
    private Sprite sprite;
    private bool isResolved;

    public void SetId(int id)
    {
        this.id = id;
    }

    public void SetSprite(Sprite sprite)
    {
        this.sprite = sprite;
    }

    public void SetResolved(bool isResolved)
    {
        this.isResolved = isResolved;
    }

    public int GetId()
    {
        return id;
    }

    public Sprite GetSprite()
    {
        return sprite;
    }

    public bool IsResolved()
    {
        return isResolved;
    }
    
}
