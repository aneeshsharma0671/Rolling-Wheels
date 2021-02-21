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

    public void FixedUpdate()
    {
        Time_Left -= Time.fixedDeltaTime;
        Score =(int)Wheel.transform.position.z;
        Score_text.text = Score.ToString();
    }
}
