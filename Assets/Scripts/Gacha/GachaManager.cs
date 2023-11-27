using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GachaManager : MonoBehaviour
{
    [SerializeField] Text prizePool;
    [SerializeField] Gacha gacha;
    [SerializeField] RankDetect rankDetect;

    void Update()
    {
        prizePool.text = gacha.prizeName;
        if (rankDetect.isSix)
        {
            prizePool.color = Color.red;
        }
        if (rankDetect.isFive)
        {
            prizePool.color = Color.yellow;
        }
        if (rankDetect.isFour)
        {
            prizePool.color = Color.magenta;
        }
        if (rankDetect.isThree)
        {
            prizePool.color = Color.cyan;
        }
        rankDetect.ResetRank();
    }
}
