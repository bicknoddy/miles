using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chance : MonoBehaviour
{
  public int level;
  public int pull;
  public int upper;
  public int lower;
  public int prob;

  public bool skillChance(string skill, int tier)
  {
    switch(skill)
    {
      case "Cooking":
        level = skillsSheet.cooking.level;
        break;
      case "Gaming":
        level = skillsSheet.gaming.level;
        break;
    }

    pull = Random.Range(1, 101);
    //find the upper and lower bounds of our probability chance
    switch(tier)
    {
      case 1:
        switch(level)
        {
          case 1:
            lower = 50;
            upper = 60;
            break;
          case 2:
            lower = 52;
            upper = 62;
            break;
          case 3:
            lower = 54;
            upper = 64;
            break;
          case 4:
            lower = 56;
            upper = 66;
            break;
          case 5:
            lower = 58;
            upper = 68;
            break;
          case 6:
            lower = 62;
            upper = 70;
            break;
          case 7:
            lower = 64;
            upper = 72;
            break;
          case 8:
            lower = 66;
            upper = 74;
            break;
          case 9:
            lower = 68;
            upper = 76;
            break;
          case 10:
            lower = 70;
            upper = 78;
            break;
          case 11:
            lower = 72;
            upper = 80;
            break;
          case 12:
            lower = 74;
            upper = 82;
            break;
          case 13:
            lower = 76;
            upper = 86;
            break;
          case 14:
            lower = 78;
            upper = 86;
            break;
          case 15:
            lower = 80;
            upper = 88;
            break;
          case 16:
            lower = 82;
            upper = 90;
            break;
          case 17:
            lower = 84;
            upper = 92;
            break;
          case 18:
            lower = 86;
            upper = 94;
            break;
          case 19:
            lower = 88;
            upper = 96;
            break;
          case 20:
            lower = 90;
            upper = 97;
            break;
          case 21:
            lower = 92;
            upper = 98;
            break;
          case 22:
            lower = 94;
            upper = 98;
            break;
          case 23:
            lower = 95;
            upper = 98;
            break;
          case 24:
            lower = 96;
            upper = 99;
            break;
          case 25:
            lower = 97;
            upper = 99;
            break;
        }
        break;
      case 2:
        switch(level)
        {
          case 7:
            lower = 30;
            upper = 60;
            break;
          case 8:
            lower = 42;
            upper = 65;
            break;
          case 9:
            lower = 51;
            upper = 68;
            break;
          case 10:
            lower = 60;
            upper = 72;
            break;
          case 11:
            lower = 65;
            upper = 75;
            break;
          case 12:
            lower = 68;
            upper = 78;
            break;
          case 13:
            lower = 70;
            upper = 80;
            break;
          case 14:
            lower = 71;
            upper = 81;
            break;
          case 15:
            lower = 73;
            upper = 82;
            break;
          case 16:
            lower = 75;
            upper = 83;
            break;
          case 17:
            lower = 75;
            upper = 84;
            break;
          case 18:
            lower = 75;
            upper = 85;
            break;
          case 19:
            lower = 78;
            upper = 86;
            break;
          case 20:
            lower = 80;
            upper = 88;
            break;
          case 21:
            lower = 82;
            upper = 90;
            break;
          case 22:
            lower = 84;
            upper = 92;
            break;
          case 23:
            lower = 86;
            upper = 93;
            break;
          case 24:
            lower = 88;
            upper = 94;
            break;
          case 25:
            lower = 90;
            upper = 95;
            break;
        }
        break;
      case 3:
        switch(level)
        {
          case 11:
            lower = 30;
            upper = 60;
            break;
          case 12:
            lower = 40;
            upper = 65;
            break;
          case 13:
            lower = 50;
            upper = 70;
            break;
          case 14:
            lower = 58;
            upper = 72;
            break;
          case 15:
            lower = 64;
            upper = 76;
            break;
          case 16:
            lower = 69;
            upper = 78;
            break;
          case 17:
            lower = 72;
            upper = 80;
            break;
          case 18:
            lower = 74;
            upper = 82;
            break;
          case 19:
            lower = 76;
            upper = 84;
            break;
          case 20:
            lower = 78;
            upper = 85;
            break;
          case 21:
            lower = 80;
            upper = 87;
            break;
          case 22:
            lower = 82;
            upper = 88;
            break;
          case 23:
            lower = 83;
            upper = 90;
            break;
          case 24:
            lower = 85;
            upper = 91;
            break;
          case 25:
            lower = 87;
            upper = 93;
            break;
        }
        break;
      case 4:
        switch(level)
        {
          case 16:
            lower = 30;
            upper = 60;
            break;
          case 17:
            lower = 40;
            upper = 70;
            break;
          case 18:
            lower = 50;
            upper = 75;
            break;
          case 19:
            lower = 55;
            upper = 80;
            break;
          case 20:
            lower = 60;
            upper = 82;
            break;
          case 21:
            lower = 70;
            upper = 83;
            break;
          case 22:
            lower = 73;
            upper = 84;
            break;
          case 23:
            lower = 77;
            upper = 86;
            break;
          case 24:
            lower = 80;
            upper = 88;
            break;
          case 25:
            lower = 83;
            upper = 90;
            break;
        }
        break;
      case 5:
        switch(level)
        {
          case 20:
            lower = 30;
            upper = 60;
            break;
          case 21:
            lower = 40;
            upper = 70;
            break;
          case 22:
            lower = 50;
            upper = 80;
            break;
          case 23:
            lower = 60;
            upper = 83;
            break;
          case 24:
            lower = 70;
            upper = 85;
            break;
          case 25:
            lower = 80;
            upper = 87;
            break;
        }
        break;
    }
    
    //find percentage from ranges assigned above
    prob = Random.Range(lower, upper);

    //final confirmation of success or fail
    if(pull > prob)
    {
      Debug.Log("You failed!");
      return false;
    }
    else
    {
      Debug.Log("You succeeded!");
      return true;
    }

  }

  public void goodDrop(string skill, int tier)
  {
      
  }
}
