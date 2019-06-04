using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{

    public Food food;
    public Material foodMaterial;

    // Debug
    public string foodName;

    private GameManager gameManager;

    private GridController grid;
    
    private MeshFilter meshFilter;
    private MeshRenderer renderer;

    private Mesh boxMesh;
    private Material boxMaterial;
    private Quaternion boxRotaion;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        grid = GetComponentInParent<GridController>();
        
        meshFilter = GetComponent<MeshFilter>();
        renderer = GetComponent<MeshRenderer>();

        boxMesh = meshFilter.sharedMesh;
        boxMaterial = renderer.material;
        boxRotaion = transform.rotation;

        foodName = food.GetFood().name;
    }

    void OnMouseDown()
    {
        if (gameManager.IsRunning())
        {
            meshFilter.sharedMesh = food.GetFood();
            transform.eulerAngles = new Vector3(0, 180, 0);
            renderer.material = foodMaterial;
            grid.CheckFood(food);
        }
    }

    public void ResetMesh()
    {
        if (food != null)
        {
            meshFilter.sharedMesh = boxMesh;
            renderer.material = boxMaterial;
            transform.rotation = boxRotaion;
        }
    }
    
}
