using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBehaviour : MonoBehaviour
{
    [SerializeField] private int score;

    public int Score => score;

    public void IncrementScore()
    {
        score++;
    }
}