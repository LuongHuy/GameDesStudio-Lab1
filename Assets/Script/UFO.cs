using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UFO : MonoBehaviour
{
    int peopleMax = 3;
    int peopleCur;
    public TextMeshPro scorePeople;

    public bool IncreasePeople (int addpeople)
    {
        int tempPeople = peopleCur;
        tempPeople += addpeople;
        if (peopleCur < peopleMax) 
        {
            peopleCur = tempPeople;
            scorePeople.text = $"{peopleCur}/{peopleMax}";           
            return true;           
        }
        return false;
    }

    public int ReleasePeople()
    {
        int tempPeopleCollect = peopleCur;
        peopleCur = 0;
        scorePeople.text = $"{peopleCur}/{peopleMax}";
        return tempPeopleCollect;
    }
  
}
