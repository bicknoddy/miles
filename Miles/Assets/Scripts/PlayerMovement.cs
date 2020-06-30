using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

  Transform player;

  void Start()
  {
    player = GetComponent<Transform>();
  }

  void Update()
  {
    if(Input.GetKey(KeyCode.W))
    {
      player.position = player.position + new Vector3(0, 250 * Time.deltaTime, 0);
    }
    else if(Input.GetKey(KeyCode.A))
    {
      player.position = player.position + new Vector3(-250 * Time.deltaTime, 0, 0);
    }
    else if(Input.GetKey(KeyCode.S))
    {
      player.position = player.position + new Vector3(0, -250 * Time.deltaTime, 0);
    }
    else if(Input.GetKey(KeyCode.D))
    {
      player.position = player.position + new Vector3(250 * Time.deltaTime, 0 , 0);
    }
  }

  
}
