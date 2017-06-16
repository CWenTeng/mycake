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


    Vector3 StartPosition;
    Vector3 previousPosition;
    Vector3 finalOffset;
    Vector3 eulerAngle;

    bool isSlide;
    float angle;


    void Awake()
    {
        trans = transform;
    }

    void strat()
    {
        //将类全部属性传给mm
        mm = GetComponent<Move>();
    }

    //移动方向以世界为坐标
    void Update()
    {
        //if (Input.GetMouseButtonDown(1) && pickon)
        //    gameObject.transform.Rotate(new Vector3(0, 100, 0));


        //旋转
        if (Input.GetMouseButtonDown(1) && pickon)
        {
            StartPosition = Input.mousePosition;
            previousPosition = Input.mousePosition;
        }
        if (Input.GetMouseButton(1) && pickon)
        {
            offset = Input.mousePosition - previousPosition;
            previousPosition = Input.mousePosition;
            transform.Rotate(Vector3.Cross(offset, Vector3.forward).normalized, offset.magnitude, Space.World);
        }
        if (Input.GetMouseButtonUp(1) && pickon)
        {
            finalOffset = Input.mousePosition - StartPosition;
            isSlide = true;
            angle = finalOffset.magnitude;
        }

        //旋转的惯性滑动
        /*if (isSlide)
        {
            transform.Rotate(Vector3.Cross(finalOffset, Vector3.forward).normalized, angle * 2 * Time.deltaTime, Space.World);
            if (angle > 0)
            {
                angle -= 5;
            }
            else
            {
                angle = 0;
            }
        }
        */

        //摧毁物体
        if (delete.del.bol() && pickon)             //如果物体被选中
        {
            Destroy(this.gameObject);               //删除该物体
        }


        if (pickon)
        {
            float v = Input.GetAxis("Vertical");                //纵坐标轴
            float b = Input.GetAxis("Horizontal");              //横坐标轴
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
                trans.transform.position = new Vector3(trans.transform.position.x, trans.transform.position.y + v, trans.transform.position.z);

            if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.A))
            {
                trans.transform.position = new Vector3(trans.transform.position.x+b, trans.transform.position.y, trans.transform.position.z);
            }
        }
    }


    //脚本同步点击
    public void hit()
    {
       
            if (!pickon)
                pickon = true;
            else
                pickon = false;
    }

    public IEnumerator OnMouseDown()
    {

        //移动被选中的物体
        if (Input.GetMouseButton(0))
        {
            if (!pickon)
                pickon = true;
            else
                pickon = false;
            link.lk.link_l(this.transform.name);
        }

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
        this.gameObject.transform.name = count.ToString();              //改名
    }

}
