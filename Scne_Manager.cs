using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Numerics;

public class Scne_Manager_1 : MonoBehaviour
{
    public GameObject Player;
    
    

    private void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.name == "LwlGecis")
        {
            SceneManager.LoadScene("02");
            
            
        }

       
    }
}
