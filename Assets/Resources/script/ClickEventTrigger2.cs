using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ClickEventTrigger2 : MonoBehaviour
{
    public void OnClick()
    {
        if (Chu.f2 == 0 && Chu.fn < 2)
        {
            GameObject.Find("Niu(Clone)").GetComponent<Fan2>().enabled = true;
            Chu.fn++;
            Invoke("juess", 1.1f);  //完全翻转后进行判定
        }
        
    }
    private void Update()
    {
        if (Chu.fan % 2 == 0 && (Chu.f2 == 1 && Chu.f22 == 0))
        {
            GameObject.Find("Niu(Clone)").GetComponent<Fan2>().enabled = true;
            Chu.f2 = 0;
            Chu.fn = 0;
        }
    }
    private void juess()  //后面进行判断的函数 
    {
        if (Chu.f2 == 0)
        {
            Chu.f2++;
            Chu.fan++;
        }
        if (Chu.f2 == 1 && Chu.f22 == 1)
        {
            GameObject.Destroy(GameObject.Find("Niu(Clone)"), 0.2f);
            GameObject.Destroy(GameObject.Find("Niu1(Clone)"), 0.2f);
            Chu.fn = 0;
        }
    }
}
