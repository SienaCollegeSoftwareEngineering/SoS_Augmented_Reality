using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClassroomMenu : MonoBehaviour
{
    public string selectedValue;
    public static string global_whereFrom;
    public void goToNewScene(string roomNum)
    {

        global_whereFrom = "ClassroomLinks";

        //string[] professors = {"None", "RB308", "RB311", "RB313", "RB314", "RB316", "RB317", "RB318", "RB319", "RB320", "RB321", "RB323", "RB326", "RB332", "RB338"};

        //string[] classrooms = {"None", "RB302", "RB304", "RB306", "RB312", "RB322", "RB324", "RB328", "RB340", "RB348", "RB350"};

        selectedValue = roomNum;    

        ModifyInfoButton.global_RoomNum = selectedValue;
        
        Debug.Log("Going to " + selectedValue);
        //Change scene to more info scene
        SceneManager.LoadScene("More Info Scene");
        
    }
}
