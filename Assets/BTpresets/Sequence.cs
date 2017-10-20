using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : Composite {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override bool Execute()
    {
        if (Selector.Execute() == true && TaskWait.WaitTime() == true)
            return true;
        else
            return false;
    }
}
