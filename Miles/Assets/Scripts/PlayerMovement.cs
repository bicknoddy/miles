using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

  Transform player;
  bool isTouchingAction;
  int speed = 500;

  void Start()
  {
    player = GetComponent<Transform>();
  }

  void Update()
  {
    if(Input.GetKey(KeyCode.W))
    {
      player.position = player.position + new Vector3(0, speed * Time.deltaTime, 0);
    }

    if(Input.GetKey(KeyCode.A))
    {
      player.position = player.position + new Vector3(-speed * Time.deltaTime, 0, 0);
    }

    if(Input.GetKey(KeyCode.S))
    {
      player.position = player.position + new Vector3(0, -speed * Time.deltaTime, 0);
    }
    
    if(Input.GetKey(KeyCode.D))
    {
      player.position = player.position + new Vector3(speed * Time.deltaTime, 0 , 0);
    }

    if(Input.GetKey(KeyCode.Space) && isTouchingAction)
    {
      Debug.Log("run action");
    }
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if(other.tag == "Action")
    {
      isTouchingAction = true;
    }
  }

  void OnTriggerExit2D(Collider2D other)
  {
    if(other.tag == "Background")
    {
      speed = -speed;
    }
  }
  
}
