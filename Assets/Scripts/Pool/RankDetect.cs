using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RankDetect : MonoBehaviour 
{
    [SerializeField] private PromiseSystem promiseSystem;
    public bool isSix;
    public bool isFive;
    public bool isFour;
    public bool isThree;
    public void Ranking()
    {
        int temp = Random.Range(1, promiseSystem.total + 1);
        if (temp <= promiseSystem.sixPoolPartial) isSix = true;
        else if (temp <= promiseSystem.sixPoolPartial + promiseSystem.fivePoolPartial) isFive = true;
        else if (temp <= promiseSystem.sixPoolPartial + promiseSystem.fivePoolPartial + promiseSystem.fourPoolPartial) isFour = true;
        else isThree = true;
    }
    public void ResetRank()
    {
        isSix = false;
        isFive = false;
        isFour = false;
        isThree = false;
    }
}

