using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private bool isRunning = false;

    void Start()
    {
        // TODO: Set isRunning to true when player hit Play button
        isRunning = true;
    }

    public bool IsRunning()
    {
        return isRunning;
    }

    public void TimeOver()
    {
        isRunning = false;
        Debug.Log("Game Over");
    }
    
}
