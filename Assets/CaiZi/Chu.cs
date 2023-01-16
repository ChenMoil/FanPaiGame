using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chu : MonoBehaviour
{
    public static int fan = 0; //定义翻牌数全局变量
    public static int f1 = 0, f11 = 0, f2 = 0, f3 = 0, f4 = 0, f5 = 0, f6 = 0, f7 = 0, f8 = 0, f22 = 0, f33 = 0, f44 = 0, f55 = 0, f66 = 0, f77 = 0,f88 = 0 ,fn = 0;
    // Start is called before the first frame update
    public void Awake()
    {
        Application.targetFrameRate = 60;  //帧数限制60
        int[,] cards = new int[4, 4];
        int z1 = 2, z2 = 2, z3 = 2, z4 = 2, z5 = 2, z6 = 2, z7 = 2, z8 = 2;
        for(int i = 0; i < 4; i++)  //随机排序
        {
            for(int b = 0; b < 4; b++)
            {
                int rg = Random.Range(1, 9);
                if(rg == 1)
                {
                    if(z1 > 0)
                    {
                        cards[i, b] = rg;
                        z1--;
                    }
                    else
                    {
                        b--;
                        continue;
                    }
                }
                if (rg == 2)
                {
                    if (z2 > 0)
                    {
                        cards[i, b] = rg;
                        z2--;
                    }
                    else
                    {
                        b--;
                        continue;
                    }
                }
                if (rg == 3)
                {
                    if (z3 > 0)
                    {
                        cards[i, b] = rg;
                        z3--;
                    }
                    else
                    {
                        b--;
                        continue;
                    }
                }
                if (rg == 4)
                {
                    if (z4 > 0)
                    {
                        cards[i, b] = rg;
                        z4--;
                    }
                    else
                    {
                        b--;
                        continue;
                    }
                }
                if (rg == 5)
                {
                    if (z5 > 0)
                    {
                        cards[i, b] = rg;
                        z5--;
                    }
                    else
                    {
                        b--;
                        continue;
                    }
                }
                if (rg == 6)
                {
                    if (z6 > 0)
                    {
                        cards[i, b] = rg;
                        z6--;
                    }
                    else
                    {
                        b--;
                        continue;
                    }
                }
                if (rg == 7)
                {
                    if (z7 > 0)
                    {
                        cards[i, b] = rg;
                        z7--;
                    }
                    else
                    {
                        b--;
                        continue;
                    }
                }
                if (rg == 8)
                {
                    if (z8 > 0)
                    {
                        cards[i, b] = rg;
                        z8--;
                    }
                    else
                    {
                        b--;
                        continue;
                    }
                }
            }
        } //随机排序
        float x = -4.5f, y = 6f, z = 0f;
        for (int i = 0; i < 4; i++)  //生成预制体
        {
            for (int b = 0; b < 4; b++)
            {
                if (cards[i,b] == 1)
                {
                    if(z1 == 1)
                    {
                        GameObject.Instantiate(Resources.Load("HuanXiong1"), new Vector3(x, y, z), Quaternion.Euler(new Vector3(90, 0, 0f)));
                    }
                    else
                    {
                        GameObject.Instantiate(Resources.Load("HuanXiong"), new Vector3(x, y, z), Quaternion.Euler(new Vector3(90, 0, 0f)));
                        z1++;
                    }
                }
                if (cards[i, b] == 2)
                {
                    if (z2 == 1)
                    {
                        GameObject.Instantiate(Resources.Load("Niu1"), new Vector3(x, y, z), Quaternion.Euler(new Vector3(90, 0, 0f)));
                    }
                    else
                    {
                        GameObject.Instantiate(Resources.Load("Niu"), new Vector3(x, y, z), Quaternion.Euler(new Vector3(90, 0, 0f)));
                        z2++;
                    }
                }
                if (cards[i, b] == 3)
                {
                    if (z3 == 1)
                    {
                        GameObject.Instantiate(Resources.Load("HuLi1"), new Vector3(x, y, z), Quaternion.Euler(new Vector3(90, 0, 0f)));
                    }
                    else
                    {
                        GameObject.Instantiate(Resources.Load("HuLi"), new Vector3(x, y, z), Quaternion.Euler(new Vector3(90, 0, 0f)));
                        z3++;
                    }
                }
                if (cards[i, b] == 4)
                {
                    if (z4 == 1)
                    {
                        GameObject.Instantiate(Resources.Load("Gou1"), new Vector3(x, y, z), Quaternion.Euler(new Vector3(90, 0, 0f)));
                    }
                    else
                    {
                        GameObject.Instantiate(Resources.Load("Gou"), new Vector3(x, y, z), Quaternion.Euler(new Vector3(90, 0, 0f)));
                        z4++;
                    }
                }
                if (cards[i, b] == 5)
                {
                    if (z5 == 1)
                    {
                        GameObject.Instantiate(Resources.Load("Lang1"), new Vector3(x, y, z), Quaternion.Euler(new Vector3(90, 0, 0f)));
                    }
                    else
                    {
                        GameObject.Instantiate(Resources.Load("Lang"), new Vector3(x, y, z), Quaternion.Euler(new Vector3(90, 0, 0f)));
                        z5++;
                    }
                }
                if (cards[i, b] == 6)
                {
                    if (z6 == 1)
                    {
                        GameObject.Instantiate(Resources.Load("Ji1"), new Vector3(x, y, z), Quaternion.Euler(new Vector3(90, 0, 0f)));
                    }
                    else
                    {
                        GameObject.Instantiate(Resources.Load("Ji"), new Vector3(x, y, z), Quaternion.Euler(new Vector3(90, 0, 0f)));
                        z6++;
                    }
                }
                if (cards[i, b] == 7)
                {
                    if (z7 == 1)
                    {
                        GameObject.Instantiate(Resources.Load("Ya1"), new Vector3(x, y, z), Quaternion.Euler(new Vector3(90, 0, 0f)));
                    }
                    else
                    {
                        GameObject.Instantiate(Resources.Load("Ya"), new Vector3(x, y, z), Quaternion.Euler(new Vector3(90, 0, 0f)));
                        z7++;
                    }
                }
                if (cards[i, b] == 8)
                {
                    if (z8 == 1)
                    {
                        GameObject.Instantiate(Resources.Load("Ge1"), new Vector3(x, y, z), Quaternion.Euler(new Vector3(90, 0, 0f)));
                    }
                    else
                    {
                        GameObject.Instantiate(Resources.Load("Ge"), new Vector3(x, y, z), Quaternion.Euler(new Vector3(90, 0, 0f)));
                        z8++;
                    }
                }
                x += 3f;
            }
            y -= 4f;
            x = -4.5f;
        }
        GameObject.Find("HuanXiong").GetComponent<Fan>().enabled = true;
        GameObject.Find("HuanXiong(Clone)").GetComponent<Fan1>().enabled = true;
        GameObject.Find("HuanXiong1(Clone)").GetComponent<Fan11>().enabled = true;
        GameObject.Find("Niu(Clone)").GetComponent<Fan2>().enabled = true;
        GameObject.Find("Niu1(Clone)").GetComponent<Fan22>().enabled = true;
        GameObject.Find("HuLi(Clone)").GetComponent<Fan3>().enabled = true;
        GameObject.Find("HuLi1(Clone)").GetComponent<Fan33>().enabled = true;
        GameObject.Find("Gou(Clone)").GetComponent<Fan4>().enabled = true;
        GameObject.Find("Gou1(Clone)").GetComponent<Fan44>().enabled = true;
        GameObject.Find("Lang(Clone)").GetComponent<Fan5>().enabled = true;
        GameObject.Find("Lang1(Clone)").GetComponent<Fan55>().enabled = true;
        GameObject.Find("Ji(Clone)").GetComponent<Fan6>().enabled = true;
        GameObject.Find("Ji1(Clone)").GetComponent<Fan66>().enabled = true;
        GameObject.Find("Ya(Clone)").GetComponent<Fan7>().enabled = true;
        GameObject.Find("Ya1(Clone)").GetComponent<Fan77>().enabled = true;
        GameObject.Find("Ge(Clone)").GetComponent<Fan8>().enabled = true;
        GameObject.Find("Ge1(Clone)").GetComponent<Fan88>().enabled = true;
        Invoke("Begin", 1.5f);
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Begin()
    {
        GameObject.Find("HuanXiong").GetComponent<Fan>().enabled = true;
        GameObject.Find("HuanXiong(Clone)").GetComponent<Fan1>().enabled = true;
        GameObject.Find("HuanXiong1(Clone)").GetComponent<Fan11>().enabled = true;
        GameObject.Find("Niu(Clone)").GetComponent<Fan2>().enabled = true;
        GameObject.Find("Niu1(Clone)").GetComponent<Fan22>().enabled = true;
        GameObject.Find("HuLi(Clone)").GetComponent<Fan3>().enabled = true;
        GameObject.Find("HuLi1(Clone)").GetComponent<Fan33>().enabled = true;
        GameObject.Find("Gou(Clone)").GetComponent<Fan4>().enabled = true;
        GameObject.Find("Gou1(Clone)").GetComponent<Fan44>().enabled = true;
        GameObject.Find("Lang(Clone)").GetComponent<Fan5>().enabled = true;
        GameObject.Find("Lang1(Clone)").GetComponent<Fan55>().enabled = true;
        GameObject.Find("Ji(Clone)").GetComponent<Fan6>().enabled = true;
        GameObject.Find("Ji1(Clone)").GetComponent<Fan66>().enabled = true;
        GameObject.Find("Ya(Clone)").GetComponent<Fan7>().enabled = true;
        GameObject.Find("Ya1(Clone)").GetComponent<Fan77>().enabled = true;
        GameObject.Find("Ge(Clone)").GetComponent<Fan8>().enabled = true;
        GameObject.Find("Ge1(Clone)").GetComponent<Fan88>().enabled = true;
    }
}
