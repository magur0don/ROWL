using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    public Dialogue Dialogue;

    public GameFlagDefine.GameFlag GameFlag;

    private ParticleSystem itemParticleSystem;

    private void Start()
    {
        itemParticleSystem = GetComponentInChildren<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        itemParticleSystem.Stop();
        
        if (GameFlag == GameFlagDefine.GameFlag.ManKeyItemGet)
        {
            if (other.gameObject.tag != "BoyCharacter")
            {
                return;
            }
            // ���̓|�C���g���Z�b�g����
            CooparationJudge.Instance.SetCooperationPoint(CooperationParam.CooperationIndex.ManKeyItemGet);
            Dialogue.DisplayDialogue("�j�炵�����Ƃ��ł���");
            return;
        }

        if (!GameFlagDefine.GetGameFlag(GameFlag))
        {
            GameFlagDefine.SetGameFlag(GameFlag);
        }
        else
        {
            return;
        }
        Dialogue.DisplayDialogue("���ʌ��ւ̌����擾����");
    }
}
