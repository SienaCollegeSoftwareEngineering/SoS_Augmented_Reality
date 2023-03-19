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
        newText.text = global_PlaqueInfo;
        Debug.Log(newText.text);
    }

    public void goToMoreInfoRoom() {
        Debug.Log("Going to " + global_PlaqueInfo);
        changeTextForNewScene();
        SceneManager.LoadScene("More Info Scene");
        
    }

    public void changeTextForNewScene() {
        switch(global_PlaqueInfo) {
            #region Roger Bacon (RB)
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
                global_TextForNewScene = "RB321";
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

    public void disableButton() {
        global_PlaqueInfo = "Waiting...";
        newText.text = "Waiting...";
        moreInfoButton.interactable = false;
    }
}