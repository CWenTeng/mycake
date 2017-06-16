using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class layer_button : MonoBehaviour {

    public bool chose;
    private Image bg;


    public static layer_button ll;    //继承

    void Start()
    {
        bg = GetComponent<Image>();
        bg.color = Color.white;
        //将类全部属性传给ll
        ll = GetComponent<layer_button>();
    }


    public void click()
    {
        if (!chose)
            chose = true;
        else
            chose = false;

        //选中变黄
        if (chose)
            bg.color = Color.yellow;



        //未选中变白
        else
            bg.color = Color.white;

        //cakes.cc.newCake(number);
        linkl.lkl.link_m(this.transform.name);          //获取图层序号

    }

    //脚本同步点击
    public void hit_l()
    {
        if (!chose)
            chose = true;
        else
            chose = false;

        //选中变黄
        if (chose)
            bg.color = Color.yellow;

        //未选中变白
        else
            bg.color = Color.white;
        
    }

        void Update()
    {
        //摧毁物体
        if (delete.del.bol() && chose)
        {
            Destroy(this.gameObject);
        }
    }
    
}
