using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.SceneManagement;

public class Fire_Gun : MonoBehaviour
{
    public int defaultAmmo=120;
    public int magSize = 30;
    public int currentAmmo;
    public int currentMagAmmo;
    public Camera camera_;
    public int Range;
    public int Damage;
    Animator animator_;
    public AudioClip ShootAudio;
    public ParticleSystem MuzzleFlash;
    public ParticleSystem Bomba;
    public AudioClip BombaPatlama;
    public Text Saglik;
    // Start is called before the first frame update
    void Start()
    {
        animator_ = GetComponent<Animator>();
        currentAmmo = defaultAmmo-magSize;
        currentMagAmmo=magSize;
    }

    // Update is called once per frame
    void Update()
    {
        Saglik.text = currentMagAmmo+"/"+ currentAmmo.ToString();

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();


        }

        if (Input.GetMouseButtonDown(0))
        {
            if(CanFire())
            {
                
                Fire();
            }
            
            
        }
        else
        {
            animator_.SetBool("ÝsMpt", false);
            animator_.SetBool("ÝsSar", false);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Bomba.Play();
            GetComponent<AudioSource>().PlayOneShot(BombaPatlama);
            Debug.Log("BOMBA BUM");
        }

        

    }

    private bool CanFire()
    {
        if (currentMagAmmo>0)
        {
            return true;
        }
        return false;
    }
    private void Reload()
    {
        currentAmmo -= magSize - currentMagAmmo;
        currentMagAmmo = magSize;
       


    }

    private void Fire()
    {
        animator_.SetBool("ÝsMpt", true);
        animator_.SetBool("ÝsSar", true);
        currentMagAmmo -= 1;
        MuzzleFlash.Emit(1);
        GetComponent<AudioSource>().PlayOneShot(ShootAudio);
        RaycastHit hit;
        if (Physics.Raycast(camera_.transform.position, camera_.transform.forward, out hit, 500))
        {
            Debug.DrawLine(transform.position, hit.point, Color.red);
            if (hit.transform.tag == "Enemy")
            {
                hit.transform.GetComponent<EnemyHealt>().hit(Damage);


            }
            else
            {

            }
        }
    }
    

}
