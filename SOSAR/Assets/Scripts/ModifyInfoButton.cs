using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ModifyInfoButton : MonoBehaviour
{
    //The more info Button on the bottom right of the scene
    public Button moreInfoButton;
    //The text for the button
    public TMP_Text newText;
    //The global variable for the plaques info that says the room number
    public static string global_PlaqueInfo;

    //Also a global variable for the room number used in other scripts
    public static string global_RoomNum;

    //Check if scavenger hunt has started to determine if the moreInfoButton will be enabled
    public static bool global_scavHuntStarted = false;
    
    //Changing the text of the button to "More info" if the scavengerhunt isnt started, otherwise change to "Unavailable" and getting the roomNum for new scene

    public void changeButtonText(string plaqueInfo) {
        
        global_PlaqueInfo = plaqueInfo;
        global_RoomNum = plaqueInfo;
        Debug.Log(global_PlaqueInfo);
        if(!global_scavHuntStarted){
            moreInfoButton = GameObject.Find("NewInfoButton").GetComponent<Button>();
            moreInfoButton.interactable = true;
            newText = GameObject.Find("InfoButtonText").GetComponent<TMP_Text>();
            newText.text = "More info";
            Debug.Log(newText.text);
        }else{
            newText = GameObject.Find("InfoButtonText").GetComponent<TMP_Text>();
            newText.text = "Unavailable";
            Debug.Log(newText.text);
        }   
        
    }
    

    //Disabling button and changing text back to "Waiting..."
    public void disableButton() {
        if (moreInfoButton != null) {
            global_PlaqueInfo = "Waiting...";
            newText.text = "Waiting...";
            moreInfoButton.interactable = false;
        }
    }

    //What is triggered when more info button is clicked, sends user to more info scene
    public void goToMoreInfoRoom() {
        Debug.Log("Going to " + global_PlaqueInfo);
        
        //Change scene to more info scene
        ClassroomMenu.global_whereFrom = "RogerBacon";
        SceneManager.LoadScene("More Info Scene");
    }
    
}