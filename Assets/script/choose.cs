using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class choose : MonoBehaviour {
    public Transform canvas;
    public Choices[] children;            //图片数组
    
    void Start()
    {
        int count = 0;                    //图片数
        for(int i=0;i<canvas.childCount;i++)
        {
            if (canvas.GetChild(i).GetComponent<Choices>() != null)
                count++;
        }
        children = new Choices[count];
        int j = 0;
        for(int i=0;i<canvas.childCount;i++)
        {
            if(canvas.GetChild(i).GetComponent<Choices>()!=null)
            {
                children[j] = canvas.GetChild(i).GetComponent<Choices>();
                j++;
            }
        }

    }
               
	void Update () {
		
	}
}
