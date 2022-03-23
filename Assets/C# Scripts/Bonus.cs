using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Bonus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    
    private int _score;

    public Action<int> OnAddScore;

    public void AddScore()
    {
        _score++;
        
        scoreText.text = _score.ToString();
        OnAddScore?.Invoke(_score);
    }
}
