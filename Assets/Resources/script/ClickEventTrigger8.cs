using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ClickEventTrigger8 : MonoBehaviour
{
    public void OnClick()
    {
        if (Chu.f8 == 0 && Chu.fn < 2)
        {
            GameObject.Find("Ge(Clone)").GetComponent<Fan8>().enabled = true;
            Chu.fn++;
            Invoke("juess", 1.1f);  //完全翻转后进行判定
        }
        
    }
    private void Update()
    {
        if (Chu.fan % 2 == 0 && (Chu.f8 == 1 && Chu.f88 == 0))
        {
            GameObject.Find("Ge(Clone)").GetComponent<Fan8>().enabled = true;
            Chu.f8 = 0;
            Chu.fn = 0;
        }
    }
    private void juess()  //后面进行判断的函数 
    {
        if (Chu.f8 == 0)
        {
            Chu.f8++;
            Chu.fan++;
        }
        if (Chu.f8 == 1 && Chu.f88 == 1)
        {
            GameObject.Destroy(GameObject.Find("Ge(Clone)"), 0.2f);
            GameObject.Destroy(GameObject.Find("Ge1(Clone)"), 0.2f);
            Chu.fn = 0;
        }
    }
}
