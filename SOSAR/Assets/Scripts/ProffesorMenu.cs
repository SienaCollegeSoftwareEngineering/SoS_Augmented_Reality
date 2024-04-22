using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProffesorMenu : MonoBehaviour
{
    public string selectedValue;
    //public static string global_whereFrom;
    public void goToNewScene(string roomNum)
    {
        //Tells the more info scene where we came from

        ClassroomMenu.global_whereFrom = "ProfessorLinks";
        //Sets the selected value to the room number
        selectedValue = roomNum;

        ModifyInfoButton.global_RoomNum = selectedValue;
        
        Debug.Log("Going to " + selectedValue);
        //Change scene to more info scene
        SceneManager.LoadScene("More Info Scene");
        
    }
}
