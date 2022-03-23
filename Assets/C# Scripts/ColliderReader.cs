using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderReader : MonoBehaviour
{

    [SerializeField] private GameObject cloudBurstsParticals;
    [SerializeField] private GameObject bubbleBurstsParticals;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Cloud")
        {
            cloudBurstsParticals.SetActive(true);
        }
        if(collision.collider.tag == "Bubble")
        {
            bubbleBurstsParticals.SetActive(true);
        }
    }
}
