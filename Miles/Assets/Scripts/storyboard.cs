using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class storyboard : MonoBehaviour
{
  public Text description;
  world world;

  void Awake()
  {
    world = GameObject.Find("WorldInfo").GetComponent<world>();
  }


}
