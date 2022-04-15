using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_spawn : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject Enemy; //prefab 받을 변수
    float small_spawn_time;

    void SpawnEnemy()
    {
        float randomX = UnityEngine.Random.Range(-15.0f, 15.5f);
        float randomZ = UnityEngine.Random.Range(-15.0f, 15.5f);
        if (enableSpawn)
        {
            GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(randomX, 35.1f, randomZ), Quaternion.identity);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        small_spawn_time = 0.0f;
        InvokeRepeating("SpawnEnemy", 3, 3);  //spawnEnemy함수를 3초후에 2초마다 반복해서 실행
    }

    // Update is called once per frame
    void Update()
    {
        small_spawn_time += Time.deltaTime;
        Debug.Log(small_spawn_time);
        if (small_spawn_time > 60.0f) //60초 뒤 small_ball 삭제
        {
            Destroy(this.gameObject);
        }
    }

}
