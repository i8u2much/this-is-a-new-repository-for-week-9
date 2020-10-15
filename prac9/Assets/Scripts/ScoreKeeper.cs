using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int score = 0;
    public int value = 10;

    public void increaseSccore()
    {
        score = score + value;
    }
    public string SentScore()
    {
        return score.ToString();
    }
}
