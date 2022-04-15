using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public static int heart = 5;

    public GameObject H1;
    public GameObject H2;
    public GameObject H3;
    public GameObject H4;
    public GameObject H5;

    public GameObject D1;
    public GameObject D2;
    public GameObject D3;
    public GameObject D4;
    public GameObject D5;
    // Start is called before the first frame update
    void Start()
    {
        H1.GetComponent<Image>().enabled = true;
        H2.GetComponent<Image>().enabled = true;
        H3.GetComponent<Image>().enabled = true;
        H4.GetComponent<Image>().enabled = true;
        H5.GetComponent<Image>().enabled = true;

        D1.GetComponent<Image>().enabled = false;
        D2.GetComponent<Image>().enabled = false;
        D3.GetComponent<Image>().enabled = false;
        D4.GetComponent<Image>().enabled = false;
        D5.GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        switch (heart)
        {
            case 4:
                H5.GetComponent<Image>().enabled = false;
                D5.GetComponent<Image>().enabled = true;
                break;
            case 3:
                H4.GetComponent<Image>().enabled = false;
                D4.GetComponent<Image>().enabled = true;
                break;
            case 2:
                H3.GetComponent<Image>().enabled = false;
                D3.GetComponent<Image>().enabled = true;
                break;
            case 1:
                H2.GetComponent<Image>().enabled = false;
                D2.GetComponent<Image>().enabled = true;
                break;
            case 0:
                H1.GetComponent<Image>().enabled = false;
                D1.GetComponent<Image>().enabled = true;
                //game over
                break;
        }


    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "smallball")
        {
            heart -= 1;
            Update();
        }

        else if(coll.gameObject.tag == "boss_1")
        {
            for (int i = 0; i < 2; i++)
            {
                heart -= 1;
                Update();
            }
        }

        else if (coll.gameObject.tag == "Monster")
        {
            heart -= 1;
            Update();
        }
    }
}
