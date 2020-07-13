using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionStart : MonoBehaviour
{
  private void OnTriggerStay(Collider other)
  {
    if(other.tag == "Action")
    {
      if(Input.GetKey(KeyCode.Space))
      {
        StartAction();
      }
    }
  }

  private void StartAction()
  {
    
  }
}
