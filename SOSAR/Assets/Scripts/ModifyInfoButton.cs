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
    public static string global_TextForNewScene;
    public static string global_PlaqueInfo;
    
    public void changeButtonText(string plaqueInfo) {
        moreInfoButton = GameObject.Find("NewInfoButton").GetComponent<Button>();
        moreInfoButton.interactable = true;
        global_PlaqueInfo = plaqueInfo;
        Debug.Log(global_PlaqueInfo);
        newText = GameObject.Find("InfoButtonText").GetComponent<TMP_Text>();
        newText.text = "More info";
        Debug.Log(newText.text);
    }

    public void disableButton() {
        global_PlaqueInfo = "Waiting...";
        newText.text = "Waiting...";
        moreInfoButton.interactable = false;
    }

    public void goToMoreInfoRoom() {
        Debug.Log("Going to " + global_PlaqueInfo);
        changeTextForNewScene();
        SceneManager.LoadScene("More Info Scene");
    }


    /*
    * For professor names: <align=\"center\"><color=#006B54><size=28px> text </size></color></align>
    * For headings: <align=\"center\"><color=#006B54><size=26px> text </size></color></align>
    * For content: <color=>
    *
    *
    *
    */
    public void changeTextForNewScene() {
        switch(global_PlaqueInfo) {
            #region Roger Bacon (RB)
            // 3rd floor
            case "RB350":
                global_TextForNewScene = "<color=#1ab2c5><align=\"center\">This is Roger Bacon 350. </color></align><br>It is the open lab where you can come to do homework and study. You might also have a class or exam in here.";
            break;
            case "RB348":
                global_TextForNewScene = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque sagittis turpis nec velit iaculis euismod sit amet quis magna. Nullam venenatis pellentesque nunc, vel ultrices felis auctor egestas. Donec auctor lobortis neque, non tristique justo euismod non. Cras vestibulum, quam sed iaculis tincidunt, sapien quam eleifend diam, eu sodales lacus neque non ex. Suspendisse hendrerit neque nec rutrum finibus. Sed aliquam, elit vitae accumsan condimentum, nunc ante bibendum lacus, ut efficitur sem erat quis nibh. Pellentesque turpis erat, viverra ut ornare nec, interdum quis odio. Maecenas et metus id mauris fringilla eleifend. Mauris lacinia sed risus ut tincidunt. Nullam molestie enim diam, at bibendum erat dapibus eu. In egestas lobortis efficitur. Integer a lacus feugiat, malesuada lacus et, semper metus.";
            break;
            case "RB340":
                global_TextForNewScene = "RB340";
            break;
            case "RB338":
                global_TextForNewScene = "RB338";
            break;
            case "RB332":
                global_TextForNewScene = "RB332";
            break;
            case "RB328":
                global_TextForNewScene = "RB328";
            break;
            case "RB326":
                global_TextForNewScene = "RB326";
            break;
            case "RB324":
                global_TextForNewScene = "RB324";
            break;
            case "RB323":
                global_TextForNewScene = "RB323";
            break;
            case "RB322":
                global_TextForNewScene = "RB322";
            break;
            case "RB321":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Jack Armitage</size></color></align><br><br><align=\"center\"><color=#006B54><size=26px>About</size></color></align><br>Jack has 30 years of experience in cyber security and IT. Jack is a firm believer that education goes beyond the classroom so he tries to bring his students experiences through projects and guest speakers. In Jack's classes students do a lot of group work so they can learn from each other. He went to UAlbany where there was often 500 students per class. Classes like that were so big, it was hard to get to know the professors on a personal level.<br> \"You don't get that here at Siena. Small class sizes, friendly faculty, great kids, and a feeling of belonging. There are many opportunities to get involved and do service work. You just can't beat it.\"<br><align=\"center\"><color=#006B54><size=26px>Classes I Teach</size></color></align><br>Cyber Security, Management Information Systems, Database<br><align=\"center\"><color=#006B54><size=26px>Hobbies + Interests</size></color></align><br>Jack loves to play golf and hike. His favorite movie is <i>The Shining</i>.";
            break;
            case "RB320":
                global_TextForNewScene = "RB320";
            break;
            case "RB319":
                global_TextForNewScene = "RB319";
            break;
            case "RB318":
                global_TextForNewScene = "RB318";
            break;
            case "RB317":
                global_TextForNewScene = "RB317";
            break;
            case "RB316":
                global_TextForNewScene = "RB316";
            break;
            case "RB315":
                global_TextForNewScene = "RB315";
            break;
            case "RB314":
                global_TextForNewScene = "RB314";
            break;
            case "RB313":
                global_TextForNewScene = "RB313";
            break;
            case "RB312":
                global_TextForNewScene = "RB312";
            break;
            case "RB311":
                global_TextForNewScene = "RB311";
            break;
            case "RB308":
                global_TextForNewScene = "RB308";
            break;
            case "RB306":
                global_TextForNewScene = "RB306";
            break;
            case "RB304":
                global_TextForNewScene = "RB304";
            break;
            case "RB302":
                global_TextForNewScene = "RB302";
            break;
            // 2nd Floor
            case "RB256":
                global_TextForNewScene = "RB256";
            break;
            case "RB254":
                global_TextForNewScene = "RB254";
            break;
            case "RB248":
                global_TextForNewScene = "RB248";
            break;
            case "RB240":
                global_TextForNewScene = "RB240";
            break;
            case "RB238":
                global_TextForNewScene = "RB238";
            break;
            case "RB236":
                global_TextForNewScene = "RB236";
            break;
            case "RB235":
                global_TextForNewScene = "RB235";
            break;
            case "RB231":
                global_TextForNewScene = "RB231";
            break;
            case "RB230":
                global_TextForNewScene = "RB230";
            break;
            case "RB229":
                global_TextForNewScene = "RB229";
            break;
            case "RB227":
                global_TextForNewScene = "RB227";
            break;
            case "RB226":
                global_TextForNewScene = "RB226";
            break;
            case "RB225":
                global_TextForNewScene = "RB225";
            break;
            case "RB224A":
                global_TextForNewScene = "RB224A";
            break;
            case "RB224":
                global_TextForNewScene = "RB224";
            break;
            case "RB223":
                global_TextForNewScene = "RB223";
            break;
            case "RB222":
                global_TextForNewScene = "RB222";
            break;
            case "RB221":
                global_TextForNewScene = "RB221";
            break;
            case "RB219":
                global_TextForNewScene = "RB219";
            break;
            case "RB212":
                global_TextForNewScene = "RB212";
            break;
            case "RB210":
                global_TextForNewScene = "RB210";
            break;
            case "RB208":
                global_TextForNewScene = "RB208";
            break;
            case "RB204":
                global_TextForNewScene = "RB204";
            break;
            case "RB202":
                global_TextForNewScene = "RB202";
            break;

            #endregion

            #region Siena Hall (SH)

            #endregion

            #region Morell Science Center (MSC)

            #endregion

            #region Foy Hall (FOY)

            #endregion

            #region Kinernan Hall (KH)

            #endregion

            #region Rosetti Hall (ROS)

            #endregion

            default:
                global_TextForNewScene = "Either you forgot to set the room, the room you set does not exist or you spelt it wrong, or it is not in the switch statement yet.";
            break;
        }
    }

    
}