using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int Score;
    public float Time_Left = 120;
    public Transform Wheel;
    public TMP_Text Score_text;
    public TMP_Text TimeLeft_text;

    public void FixedUpdate()
    {
        Time_Left -= Time.fixedDeltaTime;
        Score =(int)Wheel.transform.position.z;
        Score_text.text = Score.ToString();
        TimeLeft_text.text = Time_Left.ToString("F1");

        if(Time_Left <= 0)
        {
            GameObject.Find("SceneManager").GetComponent<SceneManagement>().GameOver();
        }
    }
}
