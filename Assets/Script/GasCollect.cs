using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasCollect : MonoBehaviour
{
    public float gasIncrease;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var gasControl = collision.gameObject.GetComponent<GasControl>();
        if (gasControl == null)
        {
            return;
        }

        if (gasControl.GasIncrease(gasIncrease))
        {
            Destroy(gameObject);
        }
    }
}
