
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public Text timerText;

    public float totalTime;
    float seconds;
    public static int clear = 0;
    static int load = 0;


    // Use this for initialization
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;
        timerText.text = seconds.ToString();
        string nowscene = SceneManager.GetActiveScene().name;
        if (load <= 500)
        {
            SceneManager.LoadScene("Start");
            load = 9999;
        }
        else if (nowscene == "SampleScene")
        {
            if (totalTime <= 0.0140065)
            {
                totalTime = 0;
                SceneManager.LoadScene("gameover");
            }
            else{
                if (Input.GetKeyDown("return"))
                {
                    clear += 1;
                    {
                        SceneManager.LoadScene("pose");
                    }
                }
            }
        }
        else if (nowscene == "Stage2")
        {
            if (totalTime <= 0.0140065)
            {
                totalTime = 0;
                SceneManager.LoadScene("gameover");
            }
            else
            {
                if (Input.GetKeyDown("return"))
                {
                    clear += 1;
                    {
                        SceneManager.LoadScene("pose");
                    }
                }
            }
        }
        else if (nowscene == "Stage3")
        {
            if (totalTime <= 0.0140065)
            {
                totalTime = 0;
                SceneManager.LoadScene("gameover");
            }
            else
            {
                if (Input.GetKeyDown("return"))
                {
                    timerText.text = "0";
                    SceneManager.LoadScene("gameclear");
                }
            }
        }
    }
    public static int c()
    {
        return clear;
    }
}