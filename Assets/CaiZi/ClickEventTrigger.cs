using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ClickEventTrigger : MonoBehaviour
{
    public void OnClick()
    {
        print("MyOnClick 点击了：：" + this.name);
        GameObject.Find("HuanXiong").GetComponent<Fan>().enabled = true;
        Invoke("juess", 1.1f);  //完全翻转后进行判定
    }
    private void Update()
    {
        
    }
    private void juess()
    {
        
    }
}
