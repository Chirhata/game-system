
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
    // Use this for initialization
    int count;
    void Start()
    {
        count = timer.c();
    }
    void Update()
    {
        string nowscene = SceneManager.GetActiveScene().name;
        if (nowscene == "pose")
        {
            if (Input.GetKeyDown("return"))
            {
                if (count == 1)
                {
                    SceneManager.LoadScene("Stage2");
                }
                else if (count == 2)
                {
                    SceneManager.LoadScene("Stage3");
                }
            }
        }
        else if (nowscene == "Start")
        {
            if (Input.GetKeyDown("return"))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}