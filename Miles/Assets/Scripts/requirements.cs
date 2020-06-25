using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class requirements : MonoBehaviour
{

  public void updateLocks()
  {
    for(int i = 0; i < actions.traveling.Count; i++)
    {
      if(actions.traveling[i].deckLvl > characterSheet.deckPower)
      {
        actions.traveling[i].locked = true;
      }
    }
  }

}
