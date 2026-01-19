using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    int currentScore = 0;

    private void Start()
    {
        scoreText.text = "Score: " + currentScore;
    }

    public void UpdateText()
    {
        currentScore++;
        scoreText.text = "Score: " + currentScore;
    }
}
