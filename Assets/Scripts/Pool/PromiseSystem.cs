using UnityEngine;

public class PromiseSystem : MonoBehaviour
{
    [SerializeField] private GachaCounter_SO gachaCounter_SO;
    /// <summary>
    /// 這個值是開始保底後最大抽取數
    /// </summary>
    public readonly int promiseCounter = 49;
    /// <summary>
    /// 通分完6星的%數
    /// </summary>
    public const int sixStarPercentPartial = 1;
    /// <summary>
    /// 通分完5星的%數
    /// </summary>
    public const int fiveStarPercentPartial = 4;
    /// <summary>
    /// 通分完4星的%數
    /// </summary>
    public const int fourStarPercentPartial = 25;
    /// <summary>
    /// 通分完3星的%數
    /// </summary>
    public const int threeStarPercentPartial = 20;
    /// <summary>
    /// 一般池6星的占比,比例算起來是 1 / 50 (沒有開始算保底的情況下)
    /// </summary>
    public int sixPoolPartial;
    /// 一般池5星的占比,比例算起來是 4 / 50 (沒有開始算保底的情況下)
    /// </summary>
    public int fivePoolPartial;
    /// <summary>
    /// 一般池4星的占比,比例算起來是 25 / 50 (沒有開始算保底的情況下)
    /// </summary>
    public int fourPoolPartial;
    /// <summary>
    /// 一般池3星的占比,比例算起來是 20 / 50 (沒有開始算保底的情況下)
    /// </summary>
    public int threePoolPartial;

    public int sixSpecialPartial;
    public int fiveSpecialPartial;
    public int fourSpecialPartial;
    public int threeSpecialPartial;

    public int total;
    private void Update()
    {
        Promise_System();
        total = sixPoolPartial + fivePoolPartial + fourPoolPartial + threePoolPartial;
    }
    protected virtual void Promise_System()//保底系統,故官方並未指出加到6星的比例如何扣除,此處以平均分散到3,4,5星做計算(非官方)
    {
        sixPoolPartial = promiseCounter * sixStarPercentPartial + (promiseCounter * gachaCounter_SO.regularPoolCounter);
        fivePoolPartial = promiseCounter * fiveStarPercentPartial - (fiveStarPercentPartial * gachaCounter_SO.regularPoolCounter);
        fourPoolPartial = promiseCounter * fourStarPercentPartial - (fourStarPercentPartial * gachaCounter_SO.regularPoolCounter);
        threePoolPartial = promiseCounter * threeStarPercentPartial - (threeStarPercentPartial * gachaCounter_SO.regularPoolCounter);

        sixSpecialPartial = promiseCounter * sixStarPercentPartial + (promiseCounter * gachaCounter_SO.specialPoolCounter);
        fiveSpecialPartial = promiseCounter * fiveStarPercentPartial - (fiveStarPercentPartial * gachaCounter_SO.specialPoolCounter);
        fourSpecialPartial = promiseCounter * fourStarPercentPartial - (fourStarPercentPartial * gachaCounter_SO.specialPoolCounter);
        threeSpecialPartial = promiseCounter * threeStarPercentPartial - (threeStarPercentPartial * gachaCounter_SO.specialPoolCounter);
    }
}
