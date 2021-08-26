using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript7 : MonoBehaviour
{
    
  
 

    void Update ()

    {

        
        if(Input.GetKey(NewBehaviourScript5.GM.forward))

            transform.position += Vector3.forward / 2;

        if( Input.GetKey(NewBehaviourScript5.GM.backward))

            transform.position += -Vector3.forward / 2;

        if( Input.GetKey(NewBehaviourScript5.GM.left))

            transform.position += Vector3.left / 2;

        if( Input.GetKey(NewBehaviourScript5.GM.right))

            transform.position += Vector3.right / 2;

        if( Input.GetKeyDown(NewBehaviourScript5.GM.jump))

            transform.position += Vector3.up / 2;

    }

}

