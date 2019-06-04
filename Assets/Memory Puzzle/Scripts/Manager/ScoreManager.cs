using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreLabel;
    public float scoreTimer;

    private GameManager gameManager;

    private float score;
    private float timer;

    void Start()
    {
        gameManager = GetComponent<GameManager>();

        timer = scoreTimer;
    }

    void Update()
    {
        if (gameManager.IsRunning())
        {
            if (timer <= 0)
            {
                timer = scoreTimer;
                score++;
            } else
                timer -= Time.deltaTime;

            scoreLabel.text = ((int) score).ToString();
        }
    }
    
}
