using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
       float currentTime;
       float  startTime;
    public Text countText;
    
   public void Start(){
    currentTime = startTime;
}
     
   public void Update(){



   currentTime += (int)1 * Time.deltaTime;

    if ((int)currentTime ==100)
        {
            SceneManager.LoadScene(3);
        }
          countText.text = ((int)currentTime).ToString();
   }
  
     
      
   }
    

