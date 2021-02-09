using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    Text scoreTxt;
    [SerializeField]

    int currentScore = 0;

    public void AddPoints(int Points)
    {
        currentScore += Points;
        scoreTxt.text = $"Score: {currentScore} points";
    }
}
