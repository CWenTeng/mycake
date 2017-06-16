using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//蛋糕生成
public class cakes : MonoBehaviour
{

    private int count = 1;

    //蛋糕预置物体

    public GameObject cake1;
    public GameObject cake2;
    public GameObject cake3;
    public GameObject cake4;
    public GameObject cake5;
    public GameObject cake6;
    public GameObject cake7;
    public GameObject cake8;
    public GameObject cake9;
    public GameObject cake10;
    public GameObject cake11;
    
    public static cakes cc;
    
    //Start函数在启动脚本时第一个执行
    void Start()
    {
        //将cakes类全部属性传给cc
        cc = GetComponent<cakes>();
    }

    //判断应生成物体
    public void newCake(int number)
    {
        if (number == 1)
        {
            create(cake1);
        }
        else if (number == 2)
        {
            create(cake2);
        }
        else if (number == 3)
        {
            create(cake3);
        }
        else if (number == 4)
        {
            create(cake4);
        }
        else if (number == 5)
        {
            create(cake5);
        }
        else if (number == 6)
        {
            create(cake6);
        }
        else if (number == 7)
        {
            create(cake7);
        }
        else if (number == 8)
        {
            create(cake8);
        }
        else if (number == 9)
        {
            create(cake9);
        }
        else if (number == 10)
        {
            create(cake10);
        }
        else if (number == 11)
        {
            create(cake11);
        }
  
    }

    //生成物体
    public void create(GameObject cak)
    {
        //生成位置，角度
        GameObject g = Instantiate(cak, new Vector3(510f, 250f, -500f), Quaternion.Euler(-90f, 0f, 0f))
 as GameObject;

        g.transform.name = count.ToString();    //改名

        count++;

        g.transform.parent = transform;         //生成于父物体之下
    }


}