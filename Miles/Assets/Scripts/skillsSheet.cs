using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillsSheet : MonoBehaviour
{

  public class skill
  {
    public int level;
    public string name;
    public int XP;

    public skill(string name)
    {
      this.name = name;
    }
    
    public void gainXP(int tier) {

      this.XP = this.XP + (tier * 3);
      
      if(this.XP >= ((4 * (Mathf.Pow(this.level, 3))) / 5))
      {
        this.level++;
      }
      

    }

  }

  //useless right now, may implement later totally in the wrong place too.
  public class item {

    public string name;
    public int minLevel;
    public string description;

    public item(string name, int min, string des)
    {
      this.name = name;
      this.minLevel = min;
      this.description = des;
    }

    public class weapon : item {
      public float attValue;
      public string equipDestination;

      public weapon(string name, int min, string des, float attValue, string equipDestination)
        : base(name, min, des) {
        this.name = name;
        this.minLevel = min;
        this.description = des;
        this.attValue = attValue;
        this.equipDestination = equipDestination;
      }
    }
  }
    
  public static skill cooking = new skill("Cooking");
  public static skill gaming = new skill("Gaming");
  public static skill socializing = new skill("Socializing");
  public static skill labor = new skill("Labor");
  public static skill finance = new skill("Finance");

}
