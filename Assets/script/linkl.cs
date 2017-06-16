using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linkl : MonoBehaviour {

    public static linkl lkl;

	// Use this for initialization
	void Start () {
        lkl = GetComponent<linkl>();
		
	}
	
    public void link_m(string name_m)               //传入图层序号
    {

        foreach(Transform childer in gameObject.transform)          //遍历
        {
            if (childer.transform.name == name_m)                   //寻找相应物体
                childer.GetComponent<Move>().hit();                 //重复物体点击事件
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
