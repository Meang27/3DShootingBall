using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (HP.heart == 0)
        {
            SceneManager.LoadScene(6);
            HP.heart = 5;
        }
    }
}
