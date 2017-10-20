using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorDistance : Selector {

    [SerializeField]
    protected static float distanciaValida; //A qué distancia puede percibir al jugador
   

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool IsPlayerAtDistance()
    {
        float dist = (objetivo.position - transform.position).magnitude; //La distancia es igual a la (magnitud )posicion del jugador - la posición actual
                                                                         //        print("Distance to other: " + dist);

        
        if (dist <= distanciaValida) //Si la distancia es menor a la viewDistance
        {
            print("Distancia válida");

            return true;
        }
        else
            return false;

    }
}
