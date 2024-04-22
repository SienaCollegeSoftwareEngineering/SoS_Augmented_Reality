using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
*   This is used for the classroom menu page. It changes the scene to the more info scened depending on the room number that was
*   selected. It also changes the wherefrom global variable to ClassroomLinks in order to remember where the user came from.
*/
public class ClassroomMenu : MonoBehaviour
{
    public string selectedValue;
    public static string global_whereFrom;
    public void goToNewScene(string roomNum)
    {

        global_whereFrom = "ClassroomLinks";

        selectedValue = roomNum;    

        ModifyInfoButton.global_RoomNum = selectedValue;
        
        Debug.Log("Going to " + selectedValue);
        //Change scene to more info scene
        SceneManager.LoadScene("More Info Scene");
        
    }
}
