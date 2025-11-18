using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject test;
    float cnt = 335503.36f;
    void Start()
    {
        this.test = GameObject.Find("Test");
    }

    void Update()
    {
        if (cnt > 0)
        {
            cnt -= this.test.transform.position.x + this.test.transform.position.y + 1000f;
            this.test.GetComponent<TextMeshProUGUI>().text = "Test:\n" + cnt.ToString("F0");
        }
        else
        {
            Debug.Log("초읽기 끝");
            SceneManager.LoadScene("SceneTrans");
        }
    }
}
