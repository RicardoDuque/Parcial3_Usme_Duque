using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskJump : Task {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool Jump()
    {
        //Salta n cantidad de veces
        if (SelectorDistance.IsPlayerAtDistance() == true)
        {
            //JUMP
            return true;
        }

        return false;
    }

}
