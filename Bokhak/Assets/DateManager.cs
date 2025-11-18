using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DateManager : MonoBehaviour
{
    GameObject date;
    int month;
    public static int day = 4;

    void Start()
    {
        this.date = GameObject.Find("Date");
        month = 3;
        // day = 4;
    }

    void Update()
    {
        // this.date.GetComponent<TextMeshProUGUI>().text = month.ToString("D2") + "/" + day.ToString("D2");
        this.date.GetComponent<TextMeshProUGUI>().text = $"{month.ToString("D2")}/{day.ToString("D2")}";
    }
}
