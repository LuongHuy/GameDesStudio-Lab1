using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Base : MonoBehaviour
{
    int collectedPeople;
    public TextMeshProUGUI peopleCollected;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var ufo = collision.gameObject.GetComponent<UFO>();
        if (ufo == null)
        {
            return;
        }

        collectedPeople += ufo.ReleasePeople();
        peopleCollected.text = collectedPeople.ToString();

        if(collectedPeople == 11)
        {
            GameManager.Instance.GameOver();
        }
    }
}
