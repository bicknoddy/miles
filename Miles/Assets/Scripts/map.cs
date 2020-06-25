using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour
{

  public enum Location
  {
    Home,
    School,
    Library,
    Gym,
    Store,
    Police,
    Zack,
    Sara,
  }

  public static Location location;

  public int distanceAway;
  public static bool canTravel;

  public int checkDistance(Location desiredLocation)
  {
    switch(location)
    {
      case Location.Home:
        switch(desiredLocation)
        {
          case Location.Home:
            Debug.Log("You are already here");
            return 0;
          case Location.Store:
            return 0;
          case Location.Gym:
            return 1;
          case Location.Library:
            return 1;
          case Location.School:
            return 0;
        }
        break;
      case Location.Library:
        switch(desiredLocation)
        {
          case Location.Home:
            return 0;
          case Location.Store:
            return 1;
          case Location.Gym:
            return 1;
          case Location.Library:
            Debug.Log("You are already here");
            return 0;
          case Location.School:
            return 0;
        }
        break;
      case Location.School:
        switch(desiredLocation)
        {
          case Location.Home:
            return 0;
          case Location.Store:
            return 1;
          case Location.Gym:
            return 2;
          case Location.Library:
            return 1;
          case Location.School:
            Debug.Log("You are already here");
            return 0;
        }
        break;
      default:
        Debug.Log("Something messed up at the location check, probably cuz there is no case for this location");
        return 0;
    }
    Debug.Log("The location check didn't work entirely");
    return 0;
  }
}