using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_spawn : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject Enemy_2; //prefab 받을 변수

    void SpawnEnemy()
    {
        float randomX = UnityEngine.Random.Range(-15.0f, 15.5f);
        float randomZ = UnityEngine.Random.Range(-15.0f, 15.5f);
        if (enableSpawn)
        {
            GameObject enemy = (GameObject)Instantiate(Enemy_2, new Vector3(randomX, 35.1f, randomZ), Quaternion.identity);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemy", 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
