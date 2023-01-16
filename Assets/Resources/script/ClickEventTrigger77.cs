using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ClickEventTrigger77 : MonoBehaviour
{
    public void OnClick()
    {
        if (Chu.f77 == 0 && Chu.fn < 2)
        {
            GameObject.Find("Ya1(Clone)").GetComponent<Fan77>().enabled = true;
            Chu.fn++;
            Invoke("juess", 1.1f);  //完全翻转后进行判定
        }
        
    }
    private void Update()
    {
        if (Chu.fan % 2 == 0 && (Chu.f7 == 0 && Chu.f77 == 1))
        {
            GameObject.Find("Ya1(Clone)").GetComponent<Fan77>().enabled = true;
            Chu.f77 = 0;
            Chu.fn = 0;
        }
    }
    private void juess()  //后面进行判断的函数 
    {
        if (Chu.f77 == 0)
        {
            Chu.f77++;
            Chu.fan++;
        }
        if (Chu.f7 == 1 && Chu.f77 == 1)
        {
            GameObject.Destroy(GameObject.Find("Ya(Clone)"), 0.2f);
            GameObject.Destroy(GameObject.Find("Ya1(Clone)"), 0.2f);
            Chu.fn = 0;
        }
    }
}
