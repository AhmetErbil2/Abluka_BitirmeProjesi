using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static bool ÝsPause;
    public GameObject PauseMenu;
    public GameObject OptionsMenu;
    public GameObject Panel;


     void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(true);
            OptionsMenu.SetActive(false);  
        }
        


    }
    public void Audio(float value)
    {
        AudioListener.volume = value;
    }
    public void option() 
    {
        OptionsMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }


    


    public void Oyna()
    {
        SceneManager.LoadScene(1);


    }
    public void Cikis() 
    { 
     Application.Quit();
    
    }

}   
