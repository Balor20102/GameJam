using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class damage : MonoBehaviour
{
    
    
     void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.name);
        Debug.Log("collision");
        //  GameControlScript.health -= 1;

        //print("test lmao");
    }
}
