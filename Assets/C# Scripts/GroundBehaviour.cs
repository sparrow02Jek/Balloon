using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBehaviour : MonoBehaviour
{
    [SerializeField] private float speedToDown;
    void Start()
    {
        Invoke("DestroyObj", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speedToDown * Time.deltaTime, 0);
    }

    void DestroyObj()
    {
        Destroy(this.gameObject, 0);
    }
}
