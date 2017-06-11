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

    public void link_l(string name_l)
    {
        foreach (Transform child in gameObject.transform)
        {
            if (child.transform.name == name_l)
                Move.mm.OnMouseDown();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
