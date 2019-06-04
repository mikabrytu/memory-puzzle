using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food
{

    private int id;
    private Mesh food;
    private bool isResolved;

    public void SetId(int id)
    {
        this.id = id;
    }

    public void SetFood(Mesh food)
    {
        this.food = food;
    }

    public void SetResolved(bool isResolved)
    {
        this.isResolved = isResolved;
    }

    public int GetId()
    {
        return id;
    }

    public Mesh GetFood()
    {
        return food;
    }

    public bool IsResolved()
    {
        return isResolved;
    }
    
}
