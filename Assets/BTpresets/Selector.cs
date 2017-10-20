using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : Composite
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override bool Execute()
    {
        if (SelectorDistance.IsPlayerAtDistance() == true || TaskJump.Jump() == true)
        {
            return true;
        }
        else
            return false;

    }
}
