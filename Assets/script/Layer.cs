using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Layer : MonoBehaviour {

    //图层计数
    private int count = 1;              //计数

    //图片置换

    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;
    public Image image6;
    public Image image7;
    public Image image8;
    public Image image9;
    public Image image10;
    public Image image11;


    public static Layer gg;

    void Start()
    {
        gg = GetComponent<Layer>();
    }

    //判断应更换图片
    public void LayerImage(int number)
    {
        if (number == 1)
        {
            swap(image1);
        }

        else if (number == 2)
        {
            swap(image2);
        }

        else if (number == 3)
        {
            swap(image3);
        }

        else if (number == 4)
        {
            swap(image4);
        }

        else if (number == 5)
        {
            swap(image5);
        }

        else if (number == 6)
        {
            swap(image6);
        }

        else if (number == 7)
        {
            swap(image7);
        }

        else if (number == 8)
        {
            swap(image8);
        }

        else if (number == 9)
        {
            swap(image9);
        }

        else if (number == 10)
        {
            swap(image10);
        }

        else if (number == 11)
        {
            swap(image11);
        }

    }

    //生成
    public void swap(Image pic)
    {
        
        //生成物体 调整位置 旋转角度
        Image t = Instantiate(pic, new Vector3(0f, 0f, -456.85f), Quaternion.Euler(0f, 0f, 0f)) as Image;

        t.transform.localScale = new Vector3(0.103f, 0.191f, 0f);                     //缩放尺寸

        //l_count.lc.clic(count);

        t.transform.name = count.ToString();                                          //改名

        //cakes.cc.link_c(count);

        t.gameObject.GetComponentInChildren<Text>().text = "图层"+ count++;           //生成图层文字

        t.transform.parent = transform;                            //生成于父物体之下

    }

}
