using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallbig : MonoBehaviour
{
    Vector3 direction = new Vector3(2, 0, 1);
    public float power = 100f;
    public GameObject small_ball;
    public GameObject big_ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision coll)
    {
        coll.gameObject.GetComponent<Rigidbody>().AddForce(direction * power);
    }
}
