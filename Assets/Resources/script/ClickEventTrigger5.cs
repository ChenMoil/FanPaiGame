using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ClickEventTrigger5 : MonoBehaviour
{
    public void OnClick()
    {
        if (Chu.f5 == 0 && Chu.fn < 2)
        {
            GameObject.Find("Lang(Clone)").GetComponent<Fan5>().enabled = true;
            Chu.fn++;
            Invoke("juess", 1.1f);  //完全翻转后进行判定
        }
        
    }
    private void Update()
    {
        if (Chu.fan % 2 == 0 && (Chu.f5 == 1 && Chu.f55 == 0))
        {
            GameObject.Find("Lang(Clone)").GetComponent<Fan5>().enabled = true;
            Chu.f5 = 0;
            Chu.fn = 0;
        }
    }
    private void juess()  //后面进行判断的函数 
    {
        if (Chu.f5 == 0)
        {
            Chu.f5++;
            Chu.fan++;
        }
        if (Chu.f5 == 1 && Chu.f55 == 1)
        {
            GameObject.Destroy(GameObject.Find("Lang(Clone)"), 0.2f);
            GameObject.Destroy(GameObject.Find("Lang1(Clone)"), 0.2f);
            Chu.fn = 0;
        }
    }
}
