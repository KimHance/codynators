using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingManager : MonoBehaviour
{
    //������ ��Ʈ�� ���� List
    //���� ������ �ִ��� ��� ��Ʈ�� ���ؾ���

    public List<GameObject> HitHatNoteList = new List<GameObject>();
    public List<GameObject> SnareNoteList = new List<GameObject>();
    public List<GameObject> CrashNoteList = new List<GameObject>();
    public List<GameObject> HighTomNoteList = new List<GameObject>();
    public List<GameObject> MidTomNoteList = new List<GameObject>();
    public List<GameObject> LowTomNoteList = new List<GameObject>();
    public List<GameObject> RideNoteList = new List<GameObject>();
    public List<GameObject> BaseNoteList = new List<GameObject>();

    [SerializeField] Transform Center = null; // �߽� �˷���
    [SerializeField] RectTransform[] timingRect = null; //�پ��� ���� ����

    EffectManager theEffect;

    //���� �ǵ��� ����� ����
    //���� ������ �ּҰ�(x), �ִ밪(y) 
    Vector2[] timingBoxs = null;

    // Start is called before the first frame update
    void Start()
    {
        theEffect = FindObjectOfType<EffectManager>();

        timingBoxs = new Vector2[timingRect.Length];
        // 0��° timingbox = perfect(���� ���� ����)
        // 3��° timingbox = bad(���� ���� ����)
        timingBoxs = new Vector2[timingRect.Length];
        for (int i = 0; i < timingRect.Length; i++)
        {
            timingBoxs[i].Set(Center.localPosition.x - timingRect[i].rect.width / 2,
                              Center.localPosition.x + timingRect[i].rect.width / 2);
        }
    }

    public void HiHatCheckTiming()
    {
        //hihat
        for (int i = 0; i < HitHatNoteList.Count; i++)
        {
            float t_notePosX = HitHatNoteList[i].transform.localPosition.x;

            for (int x = 0; x < timingBoxs.Length; x++)
            {
                if (timingBoxs[x].x <= t_notePosX && t_notePosX <= timingBoxs[x].y)
                {
                    HitHatNoteList[i].GetComponent<Note>().HideNote();
                    if (x < timingBoxs.Length - 1)
                        theEffect.HiHatHitEffect();
                    HitHatNoteList.RemoveAt(i);
                    Debug.Log("Hit" + x);
                    return;

                }
            }
        }

        Debug.Log("Miss");
    }

    public void SnareCheckTiming()
    {
        //snare
        for (int i = 0; i < SnareNoteList.Count; i++)
        {
            float t_notePosX = SnareNoteList[i].transform.localPosition.x;

            for (int x = 0; x < timingBoxs.Length; x++)
            {
                if (timingBoxs[x].x <= t_notePosX && t_notePosX <= timingBoxs[x].y)
                {
                    SnareNoteList[i].GetComponent<Note>().HideNote();
                    if (x < timingBoxs.Length - 1)
                        theEffect.SnareHitEffect();
                    SnareNoteList.RemoveAt(i);
                    Debug.Log("Hit" + x);
                    return;

                }
            }
        }
        Debug.Log("Miss");
    }

    public void CrashCheckTiming()
    {
        //crash
        for (int i = 0; i < CrashNoteList.Count; i++)
        {
            float t_notePosX = CrashNoteList[i].transform.localPosition.x;

            for (int x = 0; x < timingBoxs.Length; x++)
            {
                if (timingBoxs[x].x <= t_notePosX && t_notePosX <= timingBoxs[x].y)
                {
                    CrashNoteList[i].GetComponent<Note>().HideNote();
                    if (x < timingBoxs.Length - 1)
                        theEffect.CrashHitEffect();
                    CrashNoteList.RemoveAt(i);
                    Debug.Log("Hit" + x);
                    return;

                }
            }
        }
        Debug.Log("Miss");
    }

    public void HighTomCheckTiming()
    {
        //hitom
        for (int i = 0; i < HighTomNoteList.Count; i++)
        {
            float t_notePosX = HighTomNoteList[i].transform.localPosition.x;

            for (int x = 0; x < timingBoxs.Length; x++)
            {
                if (timingBoxs[x].x <= t_notePosX && t_notePosX <= timingBoxs[x].y)
                {
                    HighTomNoteList[i].GetComponent<Note>().HideNote();
                    if (x < timingBoxs.Length - 1)
                        theEffect.HighTomHitEffect();
                    HighTomNoteList.RemoveAt(i);
                    Debug.Log("Hit" + x);
                    return;

                }
            }
        }
        Debug.Log("Miss");
    }

    public void MidTomCheckTiming()
    {
        //midtom
        for (int i = 0; i < MidTomNoteList.Count; i++)
        {
            float t_notePosX = MidTomNoteList[i].transform.localPosition.x;

            for (int x = 0; x < timingBoxs.Length; x++)
            {
                if (timingBoxs[x].x <= t_notePosX && t_notePosX <= timingBoxs[x].y)
                {
                    MidTomNoteList[i].GetComponent<Note>().HideNote();
                    if (x < timingBoxs.Length - 1)
                        theEffect.MidTomHitEffect();
                    MidTomNoteList.RemoveAt(i);
                    Debug.Log("Hit" + x);
                    return;

                }
            }
        }
        Debug.Log("Miss");
    }

    public void LowTomCheckTiming()
    {
        //lowtom
        for (int i = 0; i < LowTomNoteList.Count; i++)
        {
            float t_notePosX = LowTomNoteList[i].transform.localPosition.x;

            for (int x = 0; x < timingBoxs.Length; x++)
            {
                if (timingBoxs[x].x <= t_notePosX && t_notePosX <= timingBoxs[x].y)
                {
                    LowTomNoteList[i].GetComponent<Note>().HideNote();
                    if (x < timingBoxs.Length - 1)
                        theEffect.LowTomHitEffect();
                    LowTomNoteList.RemoveAt(i);
                    Debug.Log("Hit" + x);
                    return;

                }
            }
        }
        Debug.Log("Miss");
    }

    public void RideCheckTiming()
    {
        //ride
        for (int i = 0; i < RideNoteList.Count; i++)
        {
            float t_notePosX = RideNoteList[i].transform.localPosition.x;

            for (int x = 0; x < timingBoxs.Length; x++)
            {
                if (timingBoxs[x].x <= t_notePosX && t_notePosX <= timingBoxs[x].y)
                {
                    RideNoteList[i].GetComponent<Note>().HideNote();
                    if (x < timingBoxs.Length - 1)
                        theEffect.RideHitEffect();
                    RideNoteList.RemoveAt(i);
                    Debug.Log("Hit" + x);
                    return;

                }
            }
        }
        Debug.Log("Miss");
    }

    public void BaseCheckTiming()
    {
        //base
        for (int i = 0; i < BaseNoteList.Count; i++)
        {
            float t_notePosX = BaseNoteList[i].transform.localPosition.x;

            for (int x = 0; x < timingBoxs.Length; x++)
            {
                if (timingBoxs[x].x <= t_notePosX && t_notePosX <= timingBoxs[x].y)
                {
                    BaseNoteList[i].GetComponent<Note>().HideNote();
                    if (x < timingBoxs.Length - 1)
                        theEffect.BaseHitEffect();
                    BaseNoteList.RemoveAt(i);
                    Debug.Log("Hit" + x);
                    return;

                }
            }
        }
        Debug.Log("Miss");
    }


}
