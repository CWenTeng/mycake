using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l_count : MonoBehaviour {

    public static l_count lc;    //继承

    public int coun = 0;

    //public int count = 1;
	// Use this for initialization
	void Start () {
        lc = GetComponent<l_count>();
	}

    public void clic(int count)
    {
        //layer_button.ll.link_l(count);
        //Move.mm.link_m(count);
        coun = count;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
