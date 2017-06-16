using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Choices : MonoBehaviour {
    public int number;              //序号
    private Image cake_img;     
    private Image bg;               
    private choose cm;
    public bool isChosen;
    public int count = 1;

    void Start() {
        bg = GetComponent<Image>();
        bg.color = Color.white;
        cm = GetComponentInParent<choose>();

	}

    //点击时触发
    public void click()
    {
        if (isChosen)
        {
            turnDown();
        }
        else
        {
            openUP();
            foreach (Choices c in cm.children)
            {
                if (c.name != this.name)
                    c.turnDown();
            }
        }

    }

    //选中变黄
    public void openUP()
    {
        bg.color = Color.yellow;
        isChosen = true;
        //GameObject en=new GameObject();
        //调用蛋糕生成函数 
        cakes.cc.newCake(number);           //调用蛋糕生成函数
        Layer.gg.LayerImage(number);        //调用图层生成函数
        //l_count.lc.clic(count);
        //count++;
        //layer_button.ll.link_l();
    }

    //未选中变白
    public void turnDown()
    {
        bg.color = Color.white;
        isChosen = false;
    }

}
