using UnityEngine;

public class PromiseSystem : MonoBehaviour
{
    [SerializeField] private GachaCounter_SO gachaCounter_SO;
    /// <summary>
    /// �o�ӭȬO�}�l�O����̤j�����
    /// </summary>
    public readonly int promiseCounter = 49;
    /// <summary>
    /// �q����6�P��%��
    /// </summary>
    public const int sixStarPercentPartial = 1;
    /// <summary>
    /// �q����5�P��%��
    /// </summary>
    public const int fiveStarPercentPartial = 4;
    /// <summary>
    /// �q����4�P��%��
    /// </summary>
    public const int fourStarPercentPartial = 25;
    /// <summary>
    /// �q����3�P��%��
    /// </summary>
    public const int threeStarPercentPartial = 20;
    /// <summary>
    /// �@���6�P���e��,��Һ�_�ӬO 1 / 50 (�S���}�l��O�������p�U)
    /// </summary>
    public int sixPoolPartial;
    /// �@���5�P���e��,��Һ�_�ӬO 4 / 50 (�S���}�l��O�������p�U)
    /// </summary>
    public int fivePoolPartial;
    /// <summary>
    /// �@���4�P���e��,��Һ�_�ӬO 25 / 50 (�S���}�l��O�������p�U)
    /// </summary>
    public int fourPoolPartial;
    /// <summary>
    /// �@���3�P���e��,��Һ�_�ӬO 20 / 50 (�S���}�l��O�������p�U)
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
    protected virtual void Promise_System()//�O���t��,�G�x��å����X�[��6�P����Ҧp�󦩰�,���B�H����������3,4,5�P���p��(�D�x��)
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
