using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Vector2 direction;
    public int sensitive;
    public float leftBorder;
    public float rightBorder;
    public float topBorder;
    public float bottomBorder;
    public Camera camera;

    void Start()
    {
        voidStartingonStart();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        transform.position = new Vector3(Mathf.Clamp(pos.x, leftBorder, rightBorder), Mathf.Clamp(pos.y, bottomBorder, topBorder), pos.z);
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, camera.WorldToScreenPoint(transform.position).x);
        Vector2 aimPoint = camera.ScreenToWorldPoint(mousePos);
        
        if (Input.GetMouseButton(0))
        {
            //transform.position = Vector3.Lerp(transform.position, aimPoint, Time.deltaTime);
            transform.position = new Vector3(Mathf.Lerp(transform.position.x, aimPoint.x * sensitive , Time.deltaTime), transform.position.y, transform.position.z);
        }
    } 

    void voidStartingonStart()
    {
        Vector3 pos = transform.position;
        float dist = Vector3.Distance(pos, Camera.main.transform.position);
        leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).x;
        rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).x;
        topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, dist)).y;
        bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).y;
    }
}
