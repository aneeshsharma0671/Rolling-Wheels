using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public GameObject SceneManager_Gameobject;
   public void Play()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

   public void Exit()
    {
        Application.Quit();
    }

    public void Awake()
    {
        GameObject.DontDestroyOnLoad(SceneManager_Gameobject);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }

    public void Retry()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
