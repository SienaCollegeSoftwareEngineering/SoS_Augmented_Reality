using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class Dropdown_Menu : MonoBehaviour


{

    public static string global_whereFrom;
    int value;
    public string selectedValue;
    public void call(string whereFrom, string room)
    {
        goToNewScene(whereFrom, room);
    }

    public void goToNewScene(string whereFrom, string room)
    {

        global_whereFrom = whereFrom;

        //string[] professors = {"None", "RB308", "RB311", "RB313", "RB314", "RB316", "RB317", "RB318", "RB319", "RB320", "RB321", "RB323", "RB326", "RB332", "RB338"};

        //string[] classrooms = {"None", "RB302", "RB304", "RB306", "RB312", "RB322", "RB324", "RB328", "RB340", "RB348", "RB350"};

        selectedValue = room;

        ModifyInfoButton.global_RoomNum = selectedValue;
        if(value != 0){
            Debug.Log("Going to " + selectedValue);
            //Change scene to more info scene
            SceneManager.LoadScene("More Info Scene");
        }
    }

}
