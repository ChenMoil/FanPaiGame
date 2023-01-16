using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ClickEventTrigger1 : MonoBehaviour
{
    public void OnClick()
    {
        if (Chu.f1 == 0 && Chu.fn < 2)
        {
            GameObject.Find("HuanXiong(Clone)").GetComponent<Fan1>().enabled = true;
            Chu.fn++;
            Invoke("juess", 1.1f);  //完全翻转后进行判定
        }
        
    }
    private void Update()
    {
        if (Chu.fan % 2 == 0 && (Chu.f1 == 1 && Chu.f11 == 0))
        {
            GameObject.Find("HuanXiong(Clone)").GetComponent<Fan1>().enabled = true;
            Chu.f1 = 0;
            Chu.fn = 0;
        }
    }
    private void juess()  //后面进行判断的函数 
    {
        if (Chu.f1 == 0)
        {
            Chu.f1++;
            Chu.fan++;
        }
        if (Chu.f1 == 1 && Chu.f11 == 1)
        {
            GameObject.Destroy(GameObject.Find("HuanXiong(Clone)"), 0.2f);
            GameObject.Destroy(GameObject.Find("HuanXiong1(Clone)"), 0.2f);
            Chu.fn = 0;
        }
        
    }
}
