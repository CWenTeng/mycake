using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class delete : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static delete del;
    public bool bool_dele=false;

	// Use this for initialization
	void Start () {
        del = GetComponent<delete>();
	}


    //鼠标按下
        public void OnPointerDown(PointerEventData evenData)
        {
           bool_dele = true;           
        }


    //鼠标抬起
    public void OnPointerUp(PointerEventData evenData)
        {
            bool_dele = false;
        }
    
    public bool bol()
    {
        return bool_dele;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
