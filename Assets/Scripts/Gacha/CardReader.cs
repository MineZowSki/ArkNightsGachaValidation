using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class CardReader : MonoBehaviour
{
    [SerializeField] GachaMachine gachaMachine;
    public List<string> members_Six = new List<string>();
    public List<string> members_SixSpecial = new List<string>();
    public List<string> members_Five = new List<string>();
    public List<string> members_Four = new List<string>();
    public List<string> members_Three = new List<string>();

    private void Start()
    {
        members_Six.AddRange(gachaMachine.GetSixMembersList());
        members_Five.AddRange(gachaMachine.GetFiveMembersList());
        members_Four.AddRange(gachaMachine.GetFourMembersList());
        members_Three.AddRange(gachaMachine.GetThreeMembersList());
    }

    public List<string> GetSixPool(List<string> memberToRemove)
    {
        return members_Six.Except(memberToRemove).ToList();
    }
    public List<string> GetSixSpecialPool(List<string> memberToRemove)
    {
        return members_SixSpecial.Except(memberToRemove).ToList();
    }
    public List<string> GetFivePool(List<string> memberToRemove)
    {
        return members_Five.Except(memberToRemove).ToList();
    }
    public List<string> GetFourPool(List<string> memberToRemove)
    {
        return members_Four.Except(memberToRemove).ToList();
    }
    public List<string> GetThreePool(List<string> memberToRemove)
    {
        return members_Three.Except(memberToRemove).ToList();
    }
    public void GetCurrentPool()
    {

    }
}
