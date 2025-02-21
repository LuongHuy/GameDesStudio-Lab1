using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var ufo = collision.gameObject.GetComponent<UFO>();
        if (ufo == null )
        {
            return;
        }

        if(ufo.IncreasePeople(1))
        {
            Destroy(gameObject);
        }
    }

}
