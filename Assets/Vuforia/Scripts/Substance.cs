using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Substance : MonoBehaviour {

    public string formula;

	void OnTriggerEnter(Collider other)
    {
        Substance otherSubstance = other.GetComponent<Substance>();

        // if two chemical collide
        if (otherSubstance)
        {
            if (formula == "Fe" && otherSubstance.formula == "HCl")
            {
                otherSubstance.gameObject.GetComponent<MeshRenderer>().material.color = new Color(99f / 255, 110f / 255, 3f / 255, 141f / 255);
                gameObject.GetComponent<Renderer>().enabled = false;
            }
        }
    }
}
