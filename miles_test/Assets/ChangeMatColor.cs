using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMatColor : MonoBehaviour
{
  [SerializeField]
  private Color color;

  private void Awake()
  {
    gameObject.GetComponent<MeshRenderer>().material.color = color;
  }
}
