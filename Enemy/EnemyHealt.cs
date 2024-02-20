using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class EnemyHealt : MonoBehaviour
{
    
    public int startHealth = 100;
    private int currentHealth;
    public int damage = 20;
    Animator animator;
    public AudioClip DieAuido;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startHealth;
        animator = GetComponent<Animator>();
        
    }

    public int GetHealth()
    {
        return currentHealth;
    }

    public void hit(int damage)
    {
        currentHealth -= damage;
        if (currentHealth == 0)
        {
            currentHealth = 0;
            animator.SetBool("ÝsDeath", true);
            GetComponent<AudioSource>().PlayOneShot(DieAuido, 0.2f);
            Destroy(gameObject, 2f);
            
        }
        

    }


}
