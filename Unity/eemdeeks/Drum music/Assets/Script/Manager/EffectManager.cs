using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    [SerializeField] Animator noteHitAnimaor = null; //��Ʈ ��Ʈ ����Ʈ
    string hit = "Hit";

    [SerializeField] Animator judgementAnimator = null;             //��Ȯ�� ����Ʈ
    [SerializeField] UnityEngine.UI.Image judgementImage = null;    //��ü�� �̹��� ����
    [SerializeField] Sprite[] judgementSprite = null;               //��Ȯ�� �迭

    public void JudgementEffect(int p_num)
    {
        judgementImage.sprite = judgementSprite[p_num];
        judgementAnimator.SetTrigger(hit);
    }

    public void NoteHitEffect()
    {
        noteHitAnimaor.SetTrigger(hit);
    }
}
