using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public float mesafe;
    public Transform Player;
    Vector3 posi;
    private Animator animator;


     void Start()
    {
        animator=GetComponent<Animator>();        
    }


     void Update()
    {
        mesafe = Vector3.Distance(transform.position, Player.position);
        posi = new Vector3(Player.position.x, transform.position.y, Player.position.z);

        if (mesafe<10f)
        {
            transform.LookAt(posi);
           

        }
        
        

    }



}
