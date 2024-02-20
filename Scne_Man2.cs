using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scne_Man2 : MonoBehaviour
{
    public GameObject Player;


    private void OnTriggerEnter(Collider Player1)
    {


        if (Player1.gameObject.name == "LwlCikis")
        {


            SceneManager.LoadScene("01");
        }
    }
}
