using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class world : MonoBehaviour
{
  public GameObject playMenu;
  public GameObject startMenu;

  public GameObject actionsMenu;
  public GameObject characterMenu;
  public GameObject logMenu;
  public GameObject optionsMenu;
  public GameObject skillsMenu;
  public GameObject description;
  public GameObject playScreen;

  public static int step;


  storyboard storyboard;
  map map;
  actions actions;

  public enum GameState
  {
    Start,
    MainMenu,
    Cutscene,
    End
  }

  public enum ActiveScreen
  {
    Actions,
    Character,
    Log,
    Options,
    Skills,
    Description,
    None
  }

  public static GameState gameState;
  public static ActiveScreen activeScreen = ActiveScreen.None;

  public void Start()
  {
    gameStart();
  }

  public void Awake()
  {
    storyboard = GameObject.Find("WorldInfo").GetComponent<storyboard>();
    map = GameObject.Find("WorldInfo").GetComponent<map>();
    actions = GameObject.Find("WorldInfo").GetComponent<actions>();
  }

  public void gameStateMachine(int state)
  {
    gameState = (GameState)state;

    //Switching through each overall gameState
    switch(gameState)
    {
      case GameState.Start:
        startMenu.SetActive(true);
        break;
      case GameState.MainMenu:
        startMenu.SetActive(false);
        playMenu.SetActive(true);
        playScreen.SetActive(true);
        break;
    }
  }

  public void playStateMachine(int state)
  {
    //unclick current menu if desired

    if(activeScreen.Equals((ActiveScreen)state))
    {
      activeScreen = ActiveScreen.None;
    }
    else
    {
      activeScreen = (ActiveScreen)state;
    }

    //switching through all availible screens on the play-gameState
    switch(activeScreen)
    {
      case ActiveScreen.Actions:
        actionsMenu.SetActive(true);
        characterMenu.SetActive(false);
        logMenu.SetActive(false);
        optionsMenu.SetActive(false);
        skillsMenu.SetActive(false);
        description.SetActive(false);
        step = 1;
        break;
      case ActiveScreen.Character:
        actionsMenu.SetActive(false);
        characterMenu.SetActive(true);
        logMenu.SetActive(false);
        optionsMenu.SetActive(false);
        skillsMenu.SetActive(false);        
        description.SetActive(false);
        step = 1;

        break;
      case ActiveScreen.Log:
        actionsMenu.SetActive(false);
        characterMenu.SetActive(false);
        logMenu.SetActive(true);
        optionsMenu.SetActive(false);
        skillsMenu.SetActive(false);
        description.SetActive(false);
        step = 1;
        break;
      case ActiveScreen.Options:
        actionsMenu.SetActive(false);
        characterMenu.SetActive(false);
        logMenu.SetActive(false);
        optionsMenu.SetActive(true);
        skillsMenu.SetActive(false);
        description.SetActive(false);
        step = 1;
        break;
      case ActiveScreen.Skills:
        actionsMenu.SetActive(false);
        characterMenu.SetActive(false);
        logMenu.SetActive(false);
        optionsMenu.SetActive(false);
        skillsMenu.SetActive(true);
        description.SetActive(false);
        step = 1;
        break;
      case ActiveScreen.Description:
        description.SetActive(true);
        actionsMenu.SetActive(false);
        characterMenu.SetActive(false);
        logMenu.SetActive(false);
        optionsMenu.SetActive(false);
        skillsMenu.SetActive(false);
        step = 1;
        break;
      case ActiveScreen.None:
        description.SetActive(false);
        actionsMenu.SetActive(false);
        characterMenu.SetActive(false);
        logMenu.SetActive(false);
        optionsMenu.SetActive(false);
        skillsMenu.SetActive(false);
        step = 0;
        break;        
    }

  }

  public void gameStart()
  {
    gameTime.timeCode = 6;
    gameTime.day = 0;
    gameStateMachine(0);
    playStateMachine(6);
    map.location = map.Location.Home;
    actions.populateButtonLists();
  }

}