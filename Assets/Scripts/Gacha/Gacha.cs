using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class Gacha : MonoBehaviour
{
    [SerializeField] Button button;
    [SerializeField] PickingMember pickingMember;
    [HideInInspector] public string prizeName;
    private void Awake()
    {
        button = GetComponent<Button>();
    }
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(GachaOneTime);
    }
    protected virtual void GachaOneTime()
    {
        prizeName = pickingMember.PickMember();
    }
    
}
