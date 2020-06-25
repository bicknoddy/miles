using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class liveStats : MonoBehaviour
{
  public Text cookingLvl;
  public Text gamingLvl;
  public Text financeLvl;
  public Text laborLvl;
  public Text socialLvl;
  
  public Text cookingXP;
  public Text gamingXP;
  public Text financeXP;
  public Text laborXP;
  public Text socialXP;

  void Update()
  {
    gamingLvl.text = "Gaming: " + skillsSheet.gaming.level;
    laborLvl.text = "Labor: " + skillsSheet.labor.level;
    financeLvl.text = "Finance: " + skillsSheet.finance.level;
    socialLvl.text = "Social: " + skillsSheet.socializing.level;
    cookingLvl.text = "Cooking: " + skillsSheet.cooking.level;
    gamingXP.text = "XP: " + skillsSheet.gaming.XP;
    cookingXP.text = "XP: " + skillsSheet.cooking.XP;
    laborXP.text = "XP: " + skillsSheet.labor.XP;
    financeXP.text = "XP: " + skillsSheet.finance.XP;
    socialXP.text = "XP: " + skillsSheet.socializing.XP;
  }
}
