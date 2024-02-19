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



    /*
    * For professor names: <align=\"center\"><color=#006B54><size=28px> text </size></color></align><br>
    * For headings: <align=\"center\"><color=#006B54><size=26px> text </size></color></align><br>
    * For content: <color=>
    * "<align=\"center\"><color=#006B54><size=28px>Professor </size></color></align><br><br><align=\"center\"><color=#006B54><size=26px>Classes I Teach</size></color></align><br><br>";
    */
    /*public void changeTextForNewScene() {
        switch(global_PlaqueInfo) {
            #region Roger Bacon (RB)
            // 3rd floor
            case "RB350":
                global_TextForNewScene = "<color=#1ab2c5><align=\"center\">Roger Bacon 350</color></align><br><br>It is the open lab where you can come to do homework and study. You might also have a class or exam in here.";
            break;
            case "RB348":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 348</size></color></align><br><br>This is the Software Engineering Lab. Students taking CSIS-410 (Software Engineering I) and CSIS-415 (Software Engineering II) have labs and develop semester long apps in here. Often, you'll see students hunkered down here, hard at work on their projects.<br><br><align=\"center\"><color=#006B54><size=26px>Fun Facts</size></color></align><br>This app was made in this room!";
            break;
            case "RB340":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 340</size></color></align><br><br>RB340 is a large classroom on the 3rd floor, shared by many different majors. Not only are classes held here, but also club meetings and events.";
            break;
            case "RB328":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 328</size></color></align><br><br>RB328 is a large classroom that is a hub for activity on the third floor. Many classes are held here, as well as meetings by the Computer Science and Cyber Security Clubs.";
            break;
            case "RB324":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 324</size></color></align><br><br>RB324 is the CS Library, a room that contains numerous books on several topics, ranging from programming languages to topics in mathematics to cryptography. It is a private room where you can take tests or hold meetings.";
            break;
            case "RB322":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 322</size></color></align><br><br>RB322 is a large room, used by many different classes for labs.";
            break;
            case "RB312":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 312</size></color></align><br><br>RB312, commonly known as the CS Lounge, is a room for CS majors to study and socialize. Off of the lounge is the CS Library and many professor’s rooms.";
            break;
            case "RB306":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 306</size></color></align><br><br>RB306 is a room used for CS labs.";
            break;
            case "RB304":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 304</size></color></align><br><br>RB304 is a room used for CS labs.";
            break;
            case "RB302":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 302</size></color></align><br><br>RB302 is a common classroom on the third floor. Lectures in Computer Science and Physics are commonly taught here.";
            break;
            
        }*/
    

    
}