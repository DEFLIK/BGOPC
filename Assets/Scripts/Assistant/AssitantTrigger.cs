using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssitantTrigger : MonoBehaviour
{

    // доделать 




    [SerializeField]
    private GameObject assistantTrigger;

    bool GetTriggerEnter2D (Collider2D col)
    {
        if (col == null) return false;
        else return true;
    }

    void Update()
    {

    }


}
