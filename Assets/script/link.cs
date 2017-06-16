using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class link : MonoBehaviour {

    public static link lk;

	// Use this for initialization
	void Start () {
		lk= GetComponent<link>();
    }

    public void link_l(string name_l)                           //传入物体序号
    {
        
        foreach (Transform child in gameObject.transform)       //遍历
        {
            if (child.transform.name == name_l)                 //寻找对应图层
                child.GetComponent<layer_button>().hit_l();     //重复图层点击事件
        }
        
        print(name_l);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
