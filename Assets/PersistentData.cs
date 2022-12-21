using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PersistentData : MonoBehaviour
{
    
    static PersistentData persistentData;
    public int lives;
    public int retry;
    void Start()
    {
       
        if (persistentData == null) { 
            persistentData = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if(this != persistentData)
            {
                Destroy(this.gameObject);
            }
        }


    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Main Menu")
        {
            lives = 3;
            retry = 0;
        }
    }


}
