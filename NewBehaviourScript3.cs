using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript3 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform LoadingBar;
    public Transform TextIndicator;
    public Transform TextLoading;
    [SerializeField] private float currentAmount;
    [SerializeField] private float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentAmount<100){
            currentAmount += speed * Time.deltaTime;
            TextIndicator.GetComponent<Text>().text =((int)currentAmount).ToString() + "%";
            TextLoading.gameObject.SetActive(true);

            }else{
                TextLoading.gameObject.SetActive(false);
                 //TextIndicator.GetComponent<Text>().text ="Done";
                SceneManager.LoadScene(1);

            }
            LoadingBar.GetComponent<Image>().fillAmount= currentAmount/100;
    }
}
