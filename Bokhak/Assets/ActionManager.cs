using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActionManager : MonoBehaviour
{
    GameObject ActionCntText;
    float timer = 0f;
    
    void Start()
    {
        this.ActionCntText = GameObject.Find("ActionCount");
        this.ActionCntText.GetComponent<TextMeshProUGUI>().text = $"Action Count: {APManager.ActionCount}";
    }

    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            // Debug.Log("Behavior Count: "+APManager.ActionCnt.ToString());
            this.ActionCntText.GetComponent<TextMeshProUGUI>().text = $"Action Count: {APManager.ActionCount}";
            timer = 0f;
        }
    }
}
