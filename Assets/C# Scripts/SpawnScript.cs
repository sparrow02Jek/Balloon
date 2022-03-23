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

    IEnumerator spawner() // ������� ���� ��������
    {
        while (true) // ����������� ���� While - ��������
        {
            int randInCloudList = Random.Range(0, 5);
            yield return new WaitForSeconds(1.5f); // ���� 2 �������
            float rand = Random.Range(-1f, 2.65f); // ��������� ������� �� -1 �� 4 (���� ������� ����)
            GameObject newPipes = Instantiate(cloudsList[randInCloudList], new Vector3(rand, 6, 0), Quaternion.identity);     // ��������� �������������� �� ����� gameObject � ������� ������
            Destroy(newPipes, 10);  // �������� ������ gameObject'a ����� 10 ������ (���� � ������� Pipes - �� ������ � �� ����������)
        }
    }

    
}
