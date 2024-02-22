using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ModifyInfoButton : MonoBehaviour
{
    public Button moreInfoButton;
    public TMP_Text newText;
    public TextMeshProUGUI buttonLabel;
    public static string global_ProfImageForNewScene;
    public static string global_PlaqueInfo;

    public static string global_RoomNum;
    
    //Changing the text of the button to "More info" and getting the roomNum for new scene
    public void changeButtonText(string plaqueInfo) {
        moreInfoButton = GameObject.Find("NewInfoButton").GetComponent<Button>();
        moreInfoButton.interactable = true;
        global_PlaqueInfo = plaqueInfo;
        global_RoomNum = plaqueInfo;
        Debug.Log(global_PlaqueInfo);
        newText = GameObject.Find("InfoButtonText").GetComponent<TMP_Text>();
        newText.text = "More info";
        Debug.Log(newText.text);
    }

    //Disabling button and changing text back to "Waiting..."
    public void disableButton() {
        if (moreInfoButton != null) {
            global_PlaqueInfo = "Waiting...";
            newText.text = "Waiting...";
            moreInfoButton.interactable = false;
        }
    }

    public void goToMoreInfoRoom() {
        Debug.Log("Going to " + global_PlaqueInfo);
        
        //Change scene to more info scene
        SceneManager.LoadScene("More Info Scene");
    }
    
}