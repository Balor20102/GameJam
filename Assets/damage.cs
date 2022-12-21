
 using System. Collections;
  using System. Collections.Generic;
  using UnityEngine;

public class Skullscript : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        GameControlScript.health -= 1;

    }
}
    