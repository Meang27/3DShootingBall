using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss2_spawn : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject Enemy_3; //prefab 받을 변수

    void SpawnEnemy()
    {
        float randomX = UnityEngine.Random.Range(-15.0f, 15.5f);
        float randomZ = UnityEngine.Random.Range(-15.0f, 15.5f);
        if (enableSpawn)
        {
            GameObject enemy = (GameObject)Instantiate(Enemy_3, new Vector3(randomX, 35.1f, randomZ), Quaternion.identity);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemy", 50); //50초후 생성
    }

    // Update is called once per frame
    void Update()
    {

    }
}
