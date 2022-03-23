using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject[] cloudsList = new GameObject[10];
    void Start()
    {
        Invoke("StartCor", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartCor()
    {
        StartCoroutine("spawner");
    }

    IEnumerator spawner() // собстна сама корутина
    {
        while (true) // бесконечный цикл While - работает
        {
            int randInCloudList = Random.Range(0, 5);
            yield return new WaitForSeconds(1.5f); // ждем 2 секунды
            float rand = Random.Range(-1f, 2.65f); // рандомная позиция от -1 до 4 (чтоб удобнее было)
            GameObject newPipes = Instantiate(cloudsList[randInCloudList], new Vector3(rand, 6, 0), Quaternion.identity);     // переносим отвественность на новый gameObject и создаем префаб
            Destroy(newPipes, 10);  // удаление нового gameObject'a через 10 секунд (если б удаляли Pipes - то ничего б не заработало)
        }
    }

    
}
