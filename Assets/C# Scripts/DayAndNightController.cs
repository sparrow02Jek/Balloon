using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayAndNightController : MonoBehaviour
{
    public Color color1 = Color.red;
    public Color color2 = Color.blue;
    public float duration = 3.0F;

    public Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
    }

    void Update()
    {
        if(BonusScripts._score > 3)
        {
            asd();
        }
    }

    void asd()
    {
        float t = 3;
        cam.backgroundColor = Color.Lerp(color1, color2, t);
    }
}
