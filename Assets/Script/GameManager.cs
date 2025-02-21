using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    public GameObject uiGameOver;
   public static GameManager Instance;
    private void Awake()
    {
        uiGameOver.SetActive(false);
        if (Instance == null)
        {
            Instance = this;
        }

    }

    public void GameOver()
    {
        isGameOver = true;
        uiGameOver.SetActive(true);
    }
}
