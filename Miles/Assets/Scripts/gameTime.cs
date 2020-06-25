using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameTime : MonoBehaviour
{

  public static int timeCode;
  public Text timeLabel;
  public static int day;
  public Text dayLabel;

  void Update()
  {
    dayLabel.text = "Day: " + day;

    switch(timeCode)
    {
      case 0:
        timeLabel.text = "12am";
        map.canTravel = false;
        break;
      case 1:
        timeLabel.text = " 1am";
        break;
      case 2:
        timeLabel.text = " 2am";
        break;        
      case 3:
        timeLabel.text = " 3am";
        break;
      case 4:
        timeLabel.text = " 4am";
        break;                
      case 5:
        timeLabel.text = " 5am";
        break;
      case 6:
        timeLabel.text = " 6am";
        map.canTravel =  true;
        break;
      case 7:
        timeLabel.text = " 7am";
        break;
      case 8:
        timeLabel.text = " 8am";
        break;
      case 9:
        timeLabel.text = " 9am";
        break;
      case 10:
        timeLabel.text = "10am";
        break;        
      case 11:
        timeLabel.text = "11am";
        break;
      case 12:
        timeLabel.text = "12pm";
        break;                
      case 13:
        timeLabel.text = " 1pm";
        break;
      case 14:
        timeLabel.text = " 2pm";
        break;
      case 15:
        timeLabel.text = " 3pm";
        break;
      case 16:
        timeLabel.text = " 4pm";
        break;                
      case 17:
        timeLabel.text = " 5pm";
        break;
      case 18:
        timeLabel.text = " 6pm";
        break;
      case 19:
        timeLabel.text = " 7pm";
        break;
      case 20:
        timeLabel.text = " 8pm";
        break;
      case 21:
        timeLabel.text = " 9pm";
        break;
      case 22:
        timeLabel.text = "10pm";
        break;        
      case 23:
        timeLabel.text = "11pm";
        break;
    }

    if(timeCode >= 24)
    {
      timeCode = 0;
      day++;
    }

    /*if(day = 180)
    {
      end game
    }
    */

  }

  public bool checkBedTime()
  {
    if(timeCode == 0)
    {
      return true;
    }
    return false;
  }
}