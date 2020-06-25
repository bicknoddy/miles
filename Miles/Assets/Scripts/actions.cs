using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Linq;

public class actions : MonoBehaviour
{
  public Button buttonPrefab;
  public GameObject pickActionMenu;
  public GameObject buttonListHolder;
  public GameObject backButton;

  public Button[] actionButtons = new Button[4];
  map map;
  requirements requirements;
  
  //initializing collections of all actions
  public static List<action> practicing = new List<action>();
  public static List<action> traveling = new List<action>();
  public static List<action> talking = new List<action>();
  public static List<action> observing = new List<action>();
  
  
  //initializing each action in its specified collection
  #region Instantiating Actions
  //constructors are in comments
    #region Practicing
      //(type, desc, locked, decklvl, skill)
      public action cookEgg = new action(action.Type.Practice, "Eggs", false, 1, "Cooking");
      public action cookCheese = new action(action.Type.Practice, "Grill Cheese", false, 2, "Cooking");
      public action cookSpaghetti = new action(action.Type.Practice, "Spaghetti", false, 1, "Cooking");
      public action cookBurgers = new action(action.Type.Practice, "Burgers", false, 2, "Cooking");
      public action cookRoast = new action(action.Type.Practice, "Roast", false, 1, "Cooking");
      public action cookRamen = new action(action.Type.Practice, "Ramen", false, 1, "Cooking");
      public action cookMeatloaf = new action(action.Type.Practice, "Meatloaf", false, 1, "Cooking");

      public action gameRPG = new action(action.Type.Practice, "RPG game", false, 2, "Gaming");
      public action gameFPS = new action(action.Type.Practice, "FPS game", false, 2, "Gaming");
      public action gameStrategy = new action(action.Type.Practice, "Srategy game", false, 2, "Gaming");
      public action gameSim = new action(action.Type.Practice, "Sim game", false, 2, "Gaming");
      public action gameManagement = new action(action.Type.Practice, "Manage. game", false, 2, "Gaming");
      public action gameIdle = new action(action.Type.Practice, "Idle game", false, 2, "Gaming");
      public action gameMultiplayer = new action(action.Type.Practice, "Multiplayer game", false, 2, "Gaming");
      public action gameCausal = new action(action.Type.Practice, "Casual game", false, 2, "Gaming");

      public action socialDiscord = new action(action.Type.Practice, "Discord", false, 1, "Social");
      public action socialYouTube = new action(action.Type.Practice, "YouTube", false, 1, "Social");
      public action socialTwitter = new action(action.Type.Practice, "Twitter", false, 1, "Social");
      public action socialInstagram = new action(action.Type.Practice, "Insta", false, 1, "Social");
      public action socialTwitch = new action(action.Type.Practice, "Twitch", false, 1, "Social");
      public action socialFacebook = new action(action.Type.Practice, "Facebook", false, 1, "Social");

      public action financeStocks = new action(action.Type.Practice, "Trade Stocks", true, 3, "Finance");
      public action financeBit = new action(action.Type.Practice, "Trade Bitcoin", false, 4, "Finance");
      public action financeExcel = new action(action.Type.Practice, "Learn Excel", false, 4, "Finance");
      public action financeTaxes = new action(action.Type.Practice, "File Taxes", false, 4, "Finance");
      public action financeCards = new action(action.Type.Practice, "Sell Cards", false, 4, "Finance");
      public action financeBudget = new action(action.Type.Practice, "Weekly Budget", false, 4, "Finance");
      
      public action laborLawn = new action(action.Type.Practice, "Mow Lawn", true, 2, "Labor");
      public action laborChores = new action(action.Type.Practice, "Do Chores", false, 1, "Labor");
      public action laborSnow = new action(action.Type.Practice, "Shovel Snow", false, 1, "Labor");
      public action laborGrocery = new action(action.Type.Practice, "Grocery Bagger", false, 1, "Labor");
      public action laborDonnies = new action(action.Type.Practice, "Donnie's", false, 1, "Labor");
      public action laborMoving = new action(action.Type.Practice, "Moving Truck", false, 1, "Labor");
      public action laborGarageSale = new action(action.Type.Practice, "Garage Sale", false, 1, "Labor");
    #endregion

    #region Traveling
      //(type, location, locked, decklvl)
      public action toHome = new action(action.Type.Travel, "Home", false, 0);
      public action toSchool = new action(action.Type.Travel, "School", false, 0);
      public action toStore = new action(action.Type.Travel, "Store", false, 0);
      public action toGym = new action(action.Type.Travel, "Gym", false, 0);
      public action toLibrary = new action(action.Type.Travel, "Library", false, 0);
      public action toPolice = new action(action.Type.Travel, "Police", true, 0);
    #endregion

    #region Talking
      //(type, person, locked, location, decklvl)
      public action talkPops = new action(action.Type.Talk, "Pops", false, "Home", 0);
      public action talkMomma = new action(action.Type.Talk, "Momma", false, "Home", 0);
      public action talkZack = new action(action.Type.Talk, "Aaron", false, "School", 0);
    #endregion

    #region Observing
      //(type, locked, desc, decklvl, location)
      public action lookLocker = new action(action.Type.Observe, false, "Look in locker", 0, "School");
      public action lookCloset = new action(action.Type.Observe, false, "Look in closet", 0, "Home");
      public action lookOutWindow = new action(action.Type.Observe, false, "Look out window", 0, "School");
    #endregion
  #endregion

  //filling the collections with the actions
  public void populateButtonLists()
  {
    //cooking
    practicing.Add(cookEgg);
    practicing.Add(cookCheese);
    practicing.Add(cookSpaghetti);
    practicing.Add(cookBurgers);
    practicing.Add(cookRoast);
    practicing.Add(cookRamen);
    practicing.Add(cookMeatloaf);

    //gaming
    practicing.Add(gameRPG);
    practicing.Add(gameFPS);
    practicing.Add(gameStrategy);
    practicing.Add(gameSim);
    practicing.Add(gameManagement);
    practicing.Add(gameIdle);
    practicing.Add(gameMultiplayer);
    practicing.Add(gameCausal);

    //social
    practicing.Add(socialDiscord);    
    practicing.Add(socialYouTube);
    practicing.Add(socialTwitter);
    practicing.Add(socialDiscord);
    practicing.Add(socialInstagram);
    practicing.Add(socialTwitch);
    practicing.Add(socialFacebook);

    //finance
    practicing.Add(financeStocks);
    practicing.Add(financeBit);    
    practicing.Add(financeExcel);
    practicing.Add(financeTaxes);
    practicing.Add(financeCards);
    practicing.Add(financeBudget);

    //labor
    practicing.Add(laborLawn);
    practicing.Add(laborChores);
    practicing.Add(laborSnow);
    practicing.Add(laborGrocery);
    practicing.Add(laborDonnies);
    practicing.Add(laborMoving);
    practicing.Add(laborGarageSale);

    //traveling
    traveling.Add(toHome);
    traveling.Add(toSchool);
    traveling.Add(toStore);
    traveling.Add(toGym);
    traveling.Add(toLibrary);
    traveling.Add(toPolice);

    //talking
    talking.Add(talkPops);
    talking.Add(talkMomma);

    //observing
    observing.Add(lookLocker);
    observing.Add(lookCloset);
    observing.Add(lookOutWindow);
  }

  private void Awake()
  {
    for(int i = 0; i < actionButtons.Length; i++)
    {
      int index = i;
      actionButtons[index].onClick.AddListener( () => actionList());
    }

    map = GameObject.Find("WorldInfo").GetComponent<map>();
    requirements = GameObject.Find("WorldInfo").GetComponent<requirements>();
  }

  private void Update()
  {

    //back button on the actions menu
    if(world.step == 2)
    {
      backButton.SetActive(true);
      pickActionMenu.SetActive(false);
      buttonListHolder.SetActive(true);
    }
    else if(world.step == 1)
    {
      pickActionMenu.SetActive(true);
      backButton.SetActive(false);
      buttonListHolder.SetActive(false);
    }
  }

  public class action
  {
    public enum Type { Observe, Talk, Practice, Travel}

    public Type type;
    public string name;
    public bool locked;
    public int deckLvl;
    public string skill;
    public string person;
    public string location;
    public string description;

    //locations
    public action(Type type, string location, bool locked, int deckLvl)
    {
      this.type = type;
      this.location = location;
      this.locked = locked;
      this.deckLvl = deckLvl;
    }

    //practicing
    public action(Type type, string description, bool locked, int deckLvl, string skill)
    {
      this.type = type;
      this.description = description;
      this.locked = locked;
      this.deckLvl = deckLvl;
      this.skill = skill;
    }

    //talking
    public action(Type type, string person, bool locked, string location, int deckLvl)
    {
      this.type = type;
      this.person = person;
      this.locked = locked;
      this.deckLvl = deckLvl;
      this.person = person;
      this.location = location;
    }

    //observing, sorry I had to switch parameter order due to duplication with the above constructor
    public action(Type type, bool locked, string description, int deckLvl, string location)
    {
      this.type = type;
      this.locked = locked;
      this.deckLvl = deckLvl;
      this.description = description;
      this.location = location;
    }
  }

  public void travel(map.Location desiredLocation)
  {
    if(map.canTravel)
    {
      gameTime.timeCode += map.checkDistance(desiredLocation);
      map.location = desiredLocation;
      unStep();
      Debug.Log("You traveled to " + desiredLocation);
    }
    else
    {
      Debug.Log("Sorry it is too late for you to be traveling anywhere");
    }

  }

  //gathers the action group that was clicked then redirects to check availible actions and generate new list
  public void actionList()
  {
    int children = buttonListHolder.transform.childCount;
    for(int i = 0; i < children; i++)
    {
      GameObject.Destroy(buttonListHolder.transform.GetChild(i).gameObject);
    }

    Button thisButton = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
    backButton.SetActive(true);
    world.step = 2;
    if(thisButton.name == actionButtons[0].name)
    {
      generateActionList(talking);
    }
    else if(thisButton.name == actionButtons[1].name)
    {
      generateActionList(practicing);
    }
    else if(thisButton.name == actionButtons[2].name)
    {
      generateActionList(observing);
    }
    else if(thisButton.name == actionButtons[3].name)
    {
      generateActionList(traveling);
    }
  }

  public void generateActionList(List<action> listName)
  {
    List<action> displayList = 
      (from item in listName
       where item.locked == false
       select item).ToList();

    foreach (var item in displayList)
    {
      Button button = Button.Instantiate(buttonPrefab);
      button.transform.SetParent(buttonListHolder.transform, false);
      button.GetComponentInChildren<Text>().text = item.name;
      button.gameObject.SetActive(true);

      switch(item.type)
      {
        case action.Type.Travel:
          //delete the button of the location you are at
          if(map.location.ToString() == item.name)
          {
            GameObject.Destroy(button.gameObject);
          }
          switch(item.name)
          {
            case "Home":
              button.onClick.AddListener( () => travel(map.Location.Home));
              break;
            case "School":
              button.onClick.AddListener( () => travel(map.Location.School));
              break;
            case "Store":
              button.onClick.AddListener( () => travel(map.Location.Store));
              break;
            case "Gym":
              button.onClick.AddListener( () => travel(map.Location.Gym));
              break;
            case "Library":
              button.onClick.AddListener( () => travel(map.Location.Library));
              break;
            case "Zack":
              button.onClick.AddListener( () => travel(map.Location.Zack));
              break;
            case "Police":
              button.onClick.AddListener( () => travel(map.Location.Police));
              break;
          }
          break;
        default:
          executeAction(item);
          break;
      }
    }

  }

  public void executeAction(action action)
  {

  }

  //back button logic lol
  public void unStep()
  {
    world.step -= 1;
  }

}
