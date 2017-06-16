using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class bound : MonoBehaviour
{
    public GameObject cakeg;
    public bool bool_doub = false;

    // Use this for initialization
    void Start()
    {
    }

    public void op()
    {
        if (Input.GetMouseButton(0))
        {
            if (!bool_doub)
                bool_doub = true;
            else
                bool_doub = false;
            // cakeg.Move.enabled = true;
        }
    }

    //public bool bol()
    //{
    //    //      return bool_dele;
    //}

    // Update is called once per frame
    void Update()
    {

    }
}
