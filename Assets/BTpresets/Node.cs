using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node : MonoBehaviour {

    protected Node[] children;
    protected static Transform objetivo;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual bool Execute()
    {
        if (Root.Execute() == true)
        {
            return true;
        }
        else
            return false;
    }

}
