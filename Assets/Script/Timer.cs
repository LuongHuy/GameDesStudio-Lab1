using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public float timerTime;
    void Start()
    {
        StartCoroutine(timeCountdown());
    }

    IEnumerator timeCountdown()
    {
        timer.text = timerTime.ToString();
        while (timerTime > 0) 
        {
            if (GameManager.Instance.isGameOver == true)
            {
                break;
            }
            yield return new WaitForSeconds(1);
            timerTime--;
            timer.text = timerTime.ToString();
        }
        if (timerTime <= 0)
        {
            GameManager.Instance.GameOver();
        }
    }
}
