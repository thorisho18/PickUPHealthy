using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript6 : MonoBehaviour
{
  

 

    Transform menuPanel;

    Event keyEvent;

    Text buttonText;

    KeyCode newKey;

 

    bool waitingForKey;

 

 

    void Start ()

    {

        
        menuPanel = transform.Find("Panel");

        menuPanel.gameObject.SetActive(false);

        waitingForKey = false;

 


        for(int i = 0; i < menuPanel.childCount; i++)

        {

            if(menuPanel.GetChild(i).name == "ForwardKey")

                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = NewBehaviourScript5.GM.forward.ToString();

            else if(menuPanel.GetChild(i).name == "BackwardKey")

                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = NewBehaviourScript5.GM.backward.ToString();

            else if(menuPanel.GetChild(i).name == "LeftKey")

                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = NewBehaviourScript5.GM.left.ToString();

            else if(menuPanel.GetChild(i).name == "RightKey")

                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = NewBehaviourScript5.GM.right.ToString();

            else if(menuPanel.GetChild(i).name == "JumpKey")

                menuPanel.GetChild(i).GetComponentInChildren<Text>().text = NewBehaviourScript5.GM.jump.ToString();

        }

    }

 

 

    void Update ()

    {

        //Escape key will open or close the panel

        if(Input.GetKeyDown(KeyCode.Escape) && !menuPanel.gameObject.activeSelf)

            menuPanel.gameObject.SetActive(true);

        else if(Input.GetKeyDown(KeyCode.Escape) && menuPanel.gameObject.activeSelf)

            menuPanel.gameObject.SetActive(false);

    }

 

    void OnGUI()

    {

        

        keyEvent = Event.current;

 

        if(keyEvent.isKey && waitingForKey)

        {

            newKey = keyEvent.keyCode; 

            waitingForKey = false;

        }

    }

 

    public void StartAssignment(string keyName)

    {

        if(!waitingForKey)

            StartCoroutine(AssignKey(keyName));

    }

 


    public void SendText(Text text)

    {

        buttonText = text;

    }

    IEnumerator WaitForKey()

    {

        while(!keyEvent.isKey)

            yield return null;

    }

 

   
    public IEnumerator AssignKey(string keyName)

    {

        waitingForKey = true;

 

        yield return WaitForKey(); 

 

        switch(keyName)

        {

        case "forward":

            NewBehaviourScript5.GM.forward = newKey; 

            buttonText.text = NewBehaviourScript5.GM.forward.ToString(); 

            PlayerPrefs.SetString("forwardKey", NewBehaviourScript5.GM.forward.ToString()); 

            break;

        case "backward":

            NewBehaviourScript5.GM.backward = newKey; 

            buttonText.text = NewBehaviourScript5.GM.backward.ToString(); 

            PlayerPrefs.SetString("backwardKey", NewBehaviourScript5.GM.backward.ToString()); 

            break;

        case "left":

             NewBehaviourScript5.GM.left = newKey; 

            buttonText.text = NewBehaviourScript5.GM.left.ToString(); 

            PlayerPrefs.SetString("leftKey",NewBehaviourScript5.GM.left.ToString()); 

            break;

        case "right":

           NewBehaviourScript5.GM.right = newKey; 

            buttonText.text = NewBehaviourScript5.GM.right.ToString(); 

            PlayerPrefs.SetString("rightKey", NewBehaviourScript5.GM.right.ToString()); 

            break;

        case "jump":

            NewBehaviourScript5.GM.jump = newKey; 

            buttonText.text = NewBehaviourScript5.GM.jump.ToString(); 

            PlayerPrefs.SetString("jumpKey", NewBehaviourScript5.GM.jump.ToString()); 

            break;

        }

 

        yield return null;

    }

}

