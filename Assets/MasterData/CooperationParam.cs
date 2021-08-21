using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CooperationParam", menuName = "ScriptableObjects/CreateCooperationParam")]
public class CooperationParam : ScriptableObject
{
    // �����ɋ��͂�����e��ǉ����Ă���
    public enum CooperationIndex
    {
        Invalide = -1,
        ManKeyItemGet
    }

    public List<Cooperation> cooperationParams = new List<Cooperation>();
}

[System.Serializable]
public class Cooperation
{
    public CooperationParam.CooperationIndex CooperationName;

    [SerializeField]
    public int CooperationPoint;
}
