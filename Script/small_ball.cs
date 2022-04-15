using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class small_ball : MonoBehaviour
{
    public Transform exampleExplosionEffect;

    void OnTriggerEnter(Collider other)
    {
        Instantiate(exampleExplosionEffect, this.transform.position, this.transform.rotation);
    }

    void OnCollisionEnter(Collision coll)
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(UnityEngine.Random.Range(-50.0f, 50.0f), 30.0f, UnityEngine.Random.Range(-50.0f, 50.0f)));
    }
}
