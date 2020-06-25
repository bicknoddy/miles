using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterSheet : MonoBehaviour
{

  public bool roll;
  public static int strength;
  public static int intellect;
  public static int luck;
  public static double confidence;
  public static int deckPower;
  public static double cash;

  public Text strengthLabel;
  public Text intellectLabel;
  public Text luckLabel;
  public Text cashLabel;
  public Text deckPowerLabel;
  
  public void rollChar() {

    roll = true;

    if(roll)
    {
      strength = Random.Range(1, 10);
      intellect = Random.Range(1, 10);
      luck = Random.Range(1, 10);
      confidence = System.Math.Round(Random.Range(50.00f, 60.00f), 2);
      cash = System.Math.Round(Random.Range(0.00f, 10.00f), 2);
      deckPower = Random.Range(10, 30);
      roll = !roll;
    } 
  }

  void Update()
  {
    strengthLabel.text = "Strength: " + strength;
    intellectLabel.text = "Intellect: " + intellect;
    luckLabel.text = "Luck: " + luck;
    cashLabel.text = "$" + string.Format("{0:0.00}", cash);
    deckPowerLabel.text = deckPower.ToString();

  }

}
