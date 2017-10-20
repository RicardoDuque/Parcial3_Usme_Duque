using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorMove : Selector {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool MoveTo(bool m = false)
    {
        if (SelectorDistance.IsPlayerAtDistance() == true)
        {
            //Si selectorDistance = true
            this.transform.position = new Vector3(objetivo.transform.position.x,
                objetivo.transform.position.y, objetivo.transform.position.z);
            return true;
        }

        return false;
    }
}
