using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript4 : MonoBehaviour
{
    // Start is called before the first frame update
    public   GameObject  PausePannel;
    
    void Start()
    {
        OnUnPause();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnPause();
        }
        
        
    }
    public void OnPause(){
        PausePannel.SetActive(true);
       
        Time.timeScale = 0;
    }
    public void OnUnPause(){
        PausePannel.SetActive(false);
    
        Time.timeScale = 1;

    }
    public void Resume(){
       OnUnPause();
    }
    public void Play(){
         SceneManager.LoadScene(2);
    }
    public void Exit(){
            Application.Quit();
    }
}
