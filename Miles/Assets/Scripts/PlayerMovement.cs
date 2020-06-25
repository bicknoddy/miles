using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  BoxCollider2D gameWindow;
  Rigidbody2D playerRigidbody;

  void Awake()
  {
    gameWindow = GameObject.Find("Background").GetComponent<BoxCollider2D>();
    playerRigidbody = GetComponent<Rigidbody2D>();
  }

  void Update()
  {
    if(Input.GetKey(KeyCode.W))
    {
      transform.position = transform.position + new Vector3(0, 250 * Time.deltaTime, 0);
    }
    else if(Input.GetKey(KeyCode.A))
    {
      transform.position = transform.position + new Vector3(-250 * Time.deltaTime, 0, 0);
    }
    else if(Input.GetKey(KeyCode.S))
    {
      transform.position = transform.position + new Vector3(0, -250 * Time.deltaTime, 0);
    }
    else if(Input.GetKey(KeyCode.D))
    {
      transform.position = transform.position + new Vector3(250 * Time.deltaTime, 0 , 0);
    }
  }

  
}
