using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    
       Image healthBar;
       float maxHealth = 100f;
      public static float health;
        
     void Start()
    {
         healthBar= GetComponent<Image>();
         health = maxHealth;
    }

   
    void Update()
    {
         healthBar.fillAmount = health/maxHealth;

         if (health<=0){
            SceneManager.LoadScene(3);
         }
    }
    public void OnTriggerEnter(Collider collider){
        if (collider.gameObject.tag == "healthyFood"){
            
               
            health+=10f;
              Destroy(collider.gameObject);
        }
        if (collider.gameObject.tag=="junkFood"){
                
               health-=20f;
              Destroy(collider.gameObject);
             
             
        }
         if (collider.gameObject.tag =="win"){
            SceneManager.LoadScene(4);
         }
    }
}
