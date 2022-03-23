using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Windows.WebCam;

[RequireComponent(typeof(Camera))]
public class ChangingBackGround : MonoBehaviour
{
    [SerializeField] private Bonus bunuseManager; 
    [SerializeField] private List<BackbroundColor> backgroundColors = new List<BackbroundColor>();
    
    private Camera _currentCamera;

    private BackbroundColor _currentBackgroundColor;
    private int _currentBackgroundColorIndex = 0;

    private BackbroundColor NextBackground => backgroundColors[Mathf.Clamp(_currentBackgroundColorIndex + 1, 0, backgroundColors.Count - 1)];
    
    private void Start()
    {
        _currentBackgroundColor = backgroundColors[0];
        
        _currentCamera = GetComponent<Camera>();
    }

    private void OnEnable()
    {
        bunuseManager.OnAddScore += OnAddScore;
    }

    private void OnDisable()
    {
        bunuseManager.OnAddScore -= OnAddScore;
    }

    private void OnAddScore(int score)
    {
        if (score >= _currentBackgroundColor.Score ) 
        {
            StartCoroutine(ChangeColor(_currentCamera.backgroundColor, _currentBackgroundColor.Color));
            
            _currentBackgroundColor = NextBackground;
            _currentBackgroundColorIndex++;
        }
    }

    IEnumerator ChangeColor(Color oldColor, Color nextColor)
    {
        float time = 0;
        
        while (true)
        { 
            time += Time.deltaTime;
            
            if(time >= 1)
                break;
            
            _currentCamera.backgroundColor = Color.Lerp(oldColor, nextColor, time);
            yield return null;
        }
    }
}

[Serializable]
struct BackbroundColor
{
    public int Score;
    public Color Color;
}
