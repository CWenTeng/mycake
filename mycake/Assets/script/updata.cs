using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updata : MonoBehaviour {
    private float top = -255;        //顶部
    private float down = 350;        //底部
    public float x;                  //滑动距离
    public Transform canvas;         //图片滑动
    private Vector3 vMove = new Vector3();

	void Start () {
        vMove = canvas.localPosition;
	}
	

	void Update () {

        if (canvas.localPosition.y < top)           //防止出格
            vMove.y = top;
        if (canvas.localPosition.y > down)          //防止
            vMove.y = down;
        canvas.localPosition = Vector3.MoveTowards(canvas.localPosition, vMove, Time.deltaTime * 500);      //滚动速度
    }

    //向上
    public void UP()
    {
        vMove.y -= x;
    }

    //向下
    public void DOWN()
    {
        vMove.y += x;
    }

}
