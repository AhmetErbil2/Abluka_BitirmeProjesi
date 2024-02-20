using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Bom : MonoBehaviour
{
    public float Range;
    public Light pointLight;
    public AudioClip BombAudio;


    void Start()
    {
        pointLight.enabled = false;
    }
    void Update()
    {
            
        Vector3 Aim =transform.TransformDirection(Vector3.forward);
        RaycastHit hit;

        if (Physics.Raycast(transform.position,Aim,out hit))
        {
            if (hit.distance<=Range && hit.collider.gameObject.tag=="Bomba")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    GetComponent<AudioSource>().PlayOneShot(BombAudio);
                    pointLight.enabled = !pointLight.enabled;

                }
            }
        }

    }
    
}
