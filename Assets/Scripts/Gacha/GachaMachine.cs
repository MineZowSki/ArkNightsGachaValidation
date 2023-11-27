using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GachaMachine : MonoBehaviour
{
    public Members_SO membersSix_SO;
    public Members_SO membersSpecialSix_SO;
    public Members_SO membersFive_SO;
    public Members_SO membersFour_SO;
    public Members_SO membersThree_SO;
    public GachaCounter_SO gachaCounter_SO;
    public List<string> GetSixMembersList()
    {
        return membersSix_SO.members;
    }
    public List<string> GetFiveMembersList()
    {
        return membersFive_SO.members;
    }
    public List<string> GetFourMembersList()
    {
        return membersFour_SO.members;
    }
    public List<string> GetThreeMembersList()
    {
        return membersThree_SO.members;
    }

}
