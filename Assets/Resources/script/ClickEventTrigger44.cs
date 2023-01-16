using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ClickEventTrigger44 : MonoBehaviour
{
    public void OnClick()
    {
        if (Chu.f44 == 0 && Chu.fn < 2)
        {
            GameObject.Find("Gou1(Clone)").GetComponent<Fan44>().enabled = true;
            Chu.fn++;
            Invoke("juess", 1.1f);  //完全翻转后进行判定
        }
        
    }
    private void Update()
    {
        if (Chu.fan % 2 == 0 && (Chu.f4 == 0 && Chu.f44 == 1))
        {
            GameObject.Find("Gou1(Clone)").GetComponent<Fan44>().enabled = true;
            Chu.f44 = 0;
            Chu.fn = 0;
        }
    }
    private void juess()  //后面进行判断的函数 
    {
        if (Chu.f44 == 0)
        {
            Chu.f44++;
            Chu.fan++;
        }
        if (Chu.f4 == 1 && Chu.f44 == 1)
        {
            GameObject.Destroy(GameObject.Find("Gou(Clone)"), 0.2f);
            GameObject.Destroy(GameObject.Find("Gou1(Clone)"), 0.2f);
            Chu.fn = 0;
        }
    }
}
