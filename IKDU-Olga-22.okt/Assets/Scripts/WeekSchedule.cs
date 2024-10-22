using System;
using UnityEngine;

public class WeekSchedule : MonoBehaviour
{
    // in this variable the day is defined
    public string WeekDay = "Monday";



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // calling method
        MySchedule();
        MyIfSchedule();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //the switchcase shows the activities based on the cases
    public void MySchedule()
    {
        switch(WeekDay)
        {
            case "Monday":
             Debug.Log("Working Hard");
            break;
            case "Tueday":
             Debug.Log("Working Even Harder");
            break;
            case "Wednesday":
             Debug.Log("working even even harder");
            break;
            case "Thursday":
             Debug.Log("working a little harder");
            break;
            case "Friday":
             Debug.Log("working a harder");
            break;
             case "Saturday":
             Debug.Log("Sleeping");
            break;
             case "Sunday":
             Debug.Log("Sleeping harder");
            break;
        }
        
    }

    // if statement shows the activities based on the cases
    public void MyIfSchedule()
    {
        if(WeekDay == "Monday"){
            Debug.Log("i love mondays");
        }
        else if(WeekDay == "Tuesday"){
            Debug.Log("i love tuesdays");
        }
        else if(WeekDay == "Wednesday"){
            Debug.Log("i sleep");
        }
        else if(WeekDay == "Wednesday"){
            Debug.Log("i work harder");
        }
        else if(WeekDay == "Thursday"){
            Debug.Log("i work harder");
        }
        else if(WeekDay == "Friday"){
            Debug.Log("i work even harder");
        }
        else if(WeekDay == "Friday"){
            Debug.Log("i work even harder");
        }
        else if(WeekDay == "Saturday"){
            Debug.Log("i work a little harder");
        }
        else if(WeekDay == "Sunday"){
            Debug.Log("i sleep");
        }
        else // end if nothing is given
            Debug.Log("you must define day");
    }
}
