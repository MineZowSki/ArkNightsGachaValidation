using System.Collections.Generic;
using UnityEngine;

public class PickingMember : MonoBehaviour
{
    [SerializeField] private RankDetect rankDetect;
    [SerializeField] private CardReader reader;
    public string PickMember()
    {
        rankDetect.Ranking();
        if (rankDetect.isSix) return GetRandomMember(reader.members_Six);

        if (rankDetect.isFive) return GetRandomMember(reader.members_Five);
        
        if (rankDetect.isFour) return GetRandomMember(reader.members_Four);
        
        if (rankDetect.isThree) return GetRandomMember(reader.members_Three);

        return null;
    }
    private T GetRandomMember<T>(List<T> list)
    {
        if(list == null || list.Count == 0)
        {
            return default(T);
        }
        int randomIndex = Random.Range(0, list.Count);
        return list[randomIndex];
    }
}
