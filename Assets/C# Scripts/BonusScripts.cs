using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BonusScripts : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    public static int _score;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = _score.ToString();
    }
}
