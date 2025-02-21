using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GasControl : MonoBehaviour
{
    public PlayerMovement playerMov;
    public float maxGas;
    public float currentGas;
    public TextMeshProUGUI gasText;

    private void Start()
    {
        currentGas = maxGas;
        gasText.text = (currentGas / maxGas) * 100 + "%";
        StartCoroutine(gasUse());
    }
    IEnumerator gasUse() 
    {
        while (currentGas > 0)
        {
            if (playerMov.isMove == false)
            {
                yield return new WaitForEndOfFrame();
                continue;
            }
            yield return new WaitForSeconds(0.1f);
            currentGas--;
            gasText.text = (currentGas/maxGas) * 100 + "%";
        }
       
        GameManager.Instance.GameOver();
       
    }

    public bool GasIncrease(float increase)
    {
        if (currentGas >= maxGas)
        {
            return false;
        }
        currentGas += increase;
        if (currentGas > maxGas)
        {
            currentGas = maxGas;
        }
        return true;
    }
       
}
