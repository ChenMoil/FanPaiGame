using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ClickEventTrigger3 : MonoBehaviour
{
    public void OnClick()
    {
        if (Chu.f3 == 0 && Chu.fn < 2)
        {
            GameObject.Find("HuLi(Clone)").GetComponent<Fan3>().enabled = true;
            Chu.fn++;
            Invoke("juess", 1.1f);  //完全翻转后进行判定
        }
        
    }
    private void Update()
    {
        if (Chu.fan % 2 == 0 && (Chu.f3 == 1 && Chu.f33 == 0))
        {
            GameObject.Find("HuLi(Clone)").GetComponent<Fan3>().enabled = true;
            Chu.f3 = 0;
            Chu.fn = 0;
        }
    }
    private void juess()  //后面进行判断的函数 
    {
        if (Chu.f3 == 0)
        {
            Chu.f3++;
            Chu.fan++;
        }
        if (Chu.f3 == 1 && Chu.f33 == 1)
        {
            GameObject.Destroy(GameObject.Find("HuLi(Clone)"), 0.2f);
            GameObject.Destroy(GameObject.Find("HuLi1(Clone)"), 0.2f);
            Chu.fn = 0;
        }
    }
}
