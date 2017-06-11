using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m_count : MonoBehaviour
{

    public static m_count mc;    //继承

    public int counte = 0;

    //public int count = 1;
    // Use this for initialization
    void Start()
    {
        mc = GetComponent<m_count>();
    }

    public void clic_m(int count)
    {
        //layer_button.ll.link_l(count);
        //Move.mm.link_m(count);
        counte = count;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
