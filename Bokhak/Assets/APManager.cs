using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class APManager : MonoBehaviour
{
    GameObject ap;
    public static int ActionCount = 2;
    
    void Start()
    {
        this.ap = GameObject.Find("AM/PM");

        // ActionCount = 2;
        // 2025년 3월 4일 화요일을 기준으로 토요일: 1, 일요일: 2
        if (DateManager.day % 7 == 1 || DateManager.day % 7 == 2)
        {
            ActionCount += 1;
        }
        // Debug.Log("day: "+DateManager.day.ToString());
    }

    void Update()
    {
        if (ActionCount >= 2)
        {
            this.ap.GetComponent<TextMeshProUGUI>().text = $"<b><color=green>AM</color></b>/<color=#EEEEEE>PM</color>";
        }
        else
        {
            this.ap.GetComponent<TextMeshProUGUI>().text = $"<color=#EEEEEE>AM</color>/<b><color=green>PM</color></b>";
        }
    }
}
