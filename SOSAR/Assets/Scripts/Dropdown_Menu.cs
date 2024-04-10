using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class Dropdown : MonoBehaviour


{

    public static string global_whereFrom;
    int value;
    public string selectedValue;
    public void getSelectedValue(int val)
    {
        value = val;
    }

    public void changeScene(string whereFrom)
    {

        

        string[] professors = {"None", "RB308", "RB311", "RB313", "RB314", "RB316", "RB317", "RB318", "RB319", "RB320", "RB321", "RB323", "RB326", "RB332", "RB338"};

        string[] classrooms = {"None", "RB302", "RB304", "RB306", "RB312", "RB322", "RB324", "RB328", "RB340", "RB348", "RB350"};

        if(whereFrom == "Professors"){
            selectedValue = professors[value];
            global_whereFrom = "ProfessorLinks";
        }
        else{
            selectedValue = classrooms[value];
            global_whereFrom = "ClassroomLinks";
        }

        ModifyInfoButton.global_RoomNum = selectedValue;
        if(value != 0){
            Debug.Log("Going to " + selectedValue);
            //Change scene to more info scene
            SceneManager.LoadScene("More Info Scene");
        }
    }

}
