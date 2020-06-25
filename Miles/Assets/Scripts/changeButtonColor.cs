using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeButtonColor : MonoBehaviour
{
  public Color notActive;
  public Color active;

  public GameObject[] buttons = new GameObject[5];


  public void checkColor(GameObject button)
  {
    if(button.GetComponent<Image>().color == active)
    {
      button.GetComponent<Image>().color = notActive;
      button.GetComponentInChildren<Text>().color = active;
    }
    else
    {
      for(int i = 0; i < buttons.Length; i++)
      {
        if(button == buttons[i])
        {
          button.GetComponent<Image>().color = active;
          button.GetComponentInChildren<Text>().color = notActive;
        }
        else
        {
          buttons[i].GetComponent<Image>().color = notActive;
          buttons[i].GetComponentInChildren<Text>().color = active;
        }
      }
    }

  }
}
