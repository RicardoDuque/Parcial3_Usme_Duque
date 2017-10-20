using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root : Node {

    protected new Node[] children = new Node[1];


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override bool Execute()
    {
        if (Sequence.Execute() == true)
        {
            return true;
        }
        else
            return false;
    }
}
