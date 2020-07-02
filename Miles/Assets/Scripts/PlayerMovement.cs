using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

  Transform player;
  bool isTouchingAction;
  BoxCollider2D area;
  int speed = 500;
  GameObject currentAction;

  void Start()
  {
    area = GameObject.Find("GameBackground").GetComponent<BoxCollider2D>();
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

    }

    Vector3 clampedPosition = player.position;
    clampedPosition.x = Mathf.Clamp(clampedPosition.x, area.bounds.min.x + 92, area.bounds.max.x - 92);
    clampedPosition.y = Mathf.Clamp(clampedPosition.y, area.bounds.min.y + 92, area.bounds.max.y - 92);
    player.position = clampedPosition;   
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if(other.tag == "Action")
    {
      isTouchingAction = true;
      currentAction = other.gameObject;
    }
  }
  
}
