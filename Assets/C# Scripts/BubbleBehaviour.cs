using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleBehaviour : MonoBehaviour
{
    private Bonus _bonusManager;
    
    private void Start()
    {
        _bonusManager = FindObjectOfType<Bonus>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            _bonusManager.AddScore();
        }
    }
}
