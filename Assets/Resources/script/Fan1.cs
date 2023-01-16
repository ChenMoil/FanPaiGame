using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan1 : MonoBehaviour
{
    private int time =0;
    private float now;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + 1;
        now = time * 3f;
        transform.rotation = Quaternion.Euler(90, now, 0);
        if (time % 60 == 0)
        {
            GameObject.Find("HuanXiong(Clone)").GetComponent<Fan1>().enabled = false;
        }
    }
}
