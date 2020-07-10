using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  private Rigidbody player;
  private int speed = 5;
  private List<Collider> touchWalls = new List<Collider>();

  private void Awake()
  {
    player = GetComponent<Rigidbody>();
  }

  private void FixedUpdate()
  {
    float x = Input.GetAxisRaw("Horizontal");
    float z = Input.GetAxisRaw("Vertical");

    player.position += z * transform.forward * Time.deltaTime * speed;
    player.position += x * transform.right * Time.deltaTime * speed;

    if(touchWalls.Count >= 2)
    {
      if(x != 0 && z != 0)
      {
        speed = 1;
      }
    }
    else
    {
      speed = 5;
    }
  }

  private void OnCollisionEnter(Collision other)
  {
    if(other.collider.tag == "Bounds")
    {
    touchWalls.Add(other.collider);
    }
  }

  private void OnCollisionExit(Collision other)
  {
    touchWalls.Remove(other.collider);
  }

}
