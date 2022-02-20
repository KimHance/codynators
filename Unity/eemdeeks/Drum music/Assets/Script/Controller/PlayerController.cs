using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    TimingManager theTimingManager;

    void Start()
    {
        theTimingManager = FindObjectOfType<TimingManager>();
    }
    // Update is called once per frame


    void Update()
    {
        //Space �Է����� ���
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //����üũ.
            theTimingManager.CheckTiming();
        }
    }
}
