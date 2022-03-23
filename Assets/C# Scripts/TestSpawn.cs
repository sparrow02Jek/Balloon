using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpawn : MonoBehaviour
{
    public GameObject[] obj;
    float RandX;
    Vector2 whereToSpawn;
    [SerializeField]private float spawnRate = 2f;
    private float nextTime = 0.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime)
        {
            nextTime = Time.time + spawnRate;
            RandX = Random.Range(-2, 2);
            whereToSpawn = new Vector2(RandX, transform.position.y);
            GameObject obj1 =  Instantiate(obj[0], whereToSpawn, Quaternion.identity);
            Destroy(obj1, 10);
        }
    }

}
