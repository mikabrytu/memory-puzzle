using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{

    public Mesh[] meshs;

    private TimerManager timerManager;

    private List<Food> foods;
    private FoodController[] childs;
    private int idToCompare;
    public int remainingBoxes;
    private bool checking = false;

    void Awake()
    {
        timerManager = GameObject.Find("Game Manager").GetComponent<TimerManager>();

        SetupGrid();
    }

    void Update()
    {
        if (remainingBoxes == 0)
            SetupGrid();
    }

    public void CheckFood(Food food)
    {
        if (checking)
        {
            checking = false;
            
            if (food.GetId() == idToCompare)
            {
                food.SetResolved(true);
                timerManager.IncreaseTimer();
                remainingBoxes--;
            } else
            {
                foreach (FoodController item in childs)
                {
                    if (!item.food.IsResolved())
                        StartCoroutine(ResetChild(item));
                }
            }
        } else
        {
            checking = true;
            idToCompare = food.GetId();
        }
    }

    private void SetupGrid()
    {
        foods = new List<Food>();
        remainingBoxes = meshs.Length;

        // Load Cards
        for (int i = 0; i < meshs.Length; i++)
        {
            Food food = new Food();
            food.SetId(i);
            food.SetFood(meshs[i]);

            foods.Add(food);
        }

        // Duplicate Cards
        foods = Enumerable
            .Range(0, 2)
            .SelectMany(e => foods)
            .ToList();

        // Suffle cards
        foods = foods.OrderBy(a => Guid.NewGuid()).ToList();

        // Set cards to Grid
        childs = GetComponentsInChildren<FoodController>();
        for (int i = 0; i < childs.Length; i++)
        {
            childs[i].ResetMesh();
            childs[i].food = foods[i];
        }
    }

    private IEnumerator ResetChild(FoodController food)
    {
        yield return new WaitForSeconds(1.5f);
        food.ResetMesh();
        yield break;
    }
    
}
