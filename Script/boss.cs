using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boss : MonoBehaviour
{
    public Transform exampleExplosionEffect;
    int cnt;
    // Start is called before the first frame update
    void Start()
    {
        cnt = 10;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(cnt);
        cnt--;
        if (cnt == 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(9);
        }

        Instantiate(exampleExplosionEffect, this.transform.position, this.transform.rotation);
    }
    
    void OnCollisionEnter(Collision coll)
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(UnityEngine.Random.Range(-100.0f, 100.0f), 40.0f, UnityEngine.Random.Range(-100.0f, 100.0f)));
    }
}
