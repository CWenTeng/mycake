using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour {

    private Vector3 tss;        //目标物体的屏幕空间坐标
    private Vector3 tws;        //目标物体的世界空间坐标
    private Vector3 mss;        //鼠标屏幕空间坐标
    private Vector3 offset;     //偏移

    public int MoveSpeed = 50;  //速度

    private Transform trans;    //目标物体空间变换组件

    public bool pickon=false;         //选中否；

    public static Move mm;      //继承

    void Awake()
    {
        trans = transform;
    }

    void strat()
    {
        // coun = count++;
        //将类全部属性传给mm
        mm = GetComponent<Move>();
    }

    //移动方向以世界为坐标
    void Update()
    {
        //摧毁物体
        if (delete.del.bol() && pickon)
        {
            Destroy(this.gameObject);
        }


        if (pickon)
        {
            float v = Input.GetAxis("Vertical");
            float b = Input.GetAxis("Horizontal");
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
                trans.transform.position = new Vector3(trans.transform.position.x, trans.transform.position.y + v, trans.transform.position.z);
            //transform.Translate(transform.up * -v * MoveSpeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.A))
            {
                trans.transform.position = new Vector3(trans.transform.position.x+b, trans.transform.position.y, trans.transform.position.z);
            }
        }
    }


    public IEnumerator OnMouseDown()
    {

        //移动被选中的物体
        if (Input.GetMouseButton(0))
            if (!pickon)
                pickon = true;
            else
                pickon = false;


        //把目标物体的世界空间坐标转换到自身屏幕空间坐标
        tss = Camera.main.WorldToScreenPoint(trans.position);

        //存储鼠标的屏幕空间坐标（Z值使用目标物体的屏幕空间坐标）
        mss = new Vector3(Input.mousePosition.x, Input.mousePosition.y, tss.z);

        //计算目标物体与鼠标物体在世界空间中的偏移量
        offset = trans.transform.position - Camera.main.ScreenToWorldPoint(mss);

        //按下鼠标左键
        while(Input.GetMouseButton(0))
        {
            //存储鼠标在屏幕空间的坐标
            mss = new Vector3(Input.mousePosition.x, Input.mousePosition.y, tss.z);

            //把鼠标的屏幕空间坐标转移到世界空间坐标（Z值使用目标物体的屏幕空间坐标）
            tws = Camera.main.ScreenToWorldPoint(mss) + offset;

            //更新目标物体的世界空间坐标
            trans.transform.position = tws;

            //等待固定更新.

            yield return new WaitForFixedUpdate();

        }

    }

    //链接对应图层
    public void link_m(int count)
    {
        this.gameObject.transform.name = count.ToString();
    }

}
