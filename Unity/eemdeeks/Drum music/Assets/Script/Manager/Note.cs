using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float noteSpeed = 400;

    UnityEngine.UI.Image noteImage;

    void Start()
    {
        noteImage = GetComponent<UnityEngine.UI.Image>();


    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += Vector3.right * noteSpeed * Time.deltaTime;   
    }

    //��Ʈ�� hit�� ��� �Ⱥ��̰� �ϱ�.(�̹��� ���ּ�)
    public void HideNote()
    {
        noteImage.enabled = false;
    }

}
