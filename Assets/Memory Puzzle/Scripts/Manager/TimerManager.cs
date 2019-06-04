using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{

    public float sessionTime;
    public float plusTime;

    [SerializeField]
    private Slider slider;

    private GameManager gameManager;
    private float timer;

    void Start()
    {
        gameManager = GetComponent<GameManager>();

        timer = sessionTime;
        slider.maxValue = sessionTime;
    }

    void Update()
    {
        slider.value = timer;

        if (gameManager.IsRunning())
        {
            if (timer <= 0)
                gameManager.TimeOver();    
            else
                timer -= Time.deltaTime;
        }
    }

    public void IncreaseTimer()
    {
        timer += plusTime;
    }
    
}
