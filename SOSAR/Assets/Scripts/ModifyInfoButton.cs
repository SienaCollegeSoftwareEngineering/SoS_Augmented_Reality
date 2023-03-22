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
    * For professor names: <align=\"center\"><color=#006B54><size=28px> text </size></color></align><br>
    * For headings: <align=\"center\"><color=#006B54><size=26px> text </size></color></align><br>
    * For content: <color=>
    * "<align=\"center\"><color=#006B54><size=28px>Professor </size></color></align><br><br><align=\"center\"><color=#006B54><size=26px>Classes I Teach</size></color></align><br><br>";
    *
    *
    */
    public void changeTextForNewScene() {
        switch(global_PlaqueInfo) {
            #region Roger Bacon (RB)
            // 3rd floor
            case "RB350":
                global_TextForNewScene = "<color=#1ab2c5><align=\"center\">Roger Bacon 350</color></align><br>It is the open lab where you can come to do homework and study. You might also have a class or exam in here.";
            break;
            case "RB348":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Roger Bacon 348</size></color></align><br>This is the Software Engineering Lab. Students taking CSIS-410 (Software Engineering I) and CSIS-415 (Software Engineering II) have labs and develop semester long apps in here. Often, you'll see students hunkered down here, hard at work on their projects.<br><br><align=\"center\"><color=#006B54><size=26px>Fun Facts</size></color></align><br>This app was made in this room!";
            break;
            case "RB340":
                global_TextForNewScene = "RB340";
            break;
            case "RB338":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Dr. MaryAnne Egan</size></color></align><br><br><align=\"center\"><color=#006B54><size=26px>About</size></color></align><br>Dr. Egan recognizes and works to act on the issues of underrepresentation in Computer Science. She has worked on grants to increase the number of Computer Science teachers in NY, is involved in the Women in Computer Science Club, and often teaches students how to make their developed applications more accessible for everyone.<br>\"Having been around Siena most of my life (my dad taught here), I see how the professors really care about the students and that the people are amazing. The small teacher to student ratio makes it easy for professors to discover individual students' talents and suggest ways to help them learn and improve. \"<br><align=\"center\"><color=#006B54><size=26px>Classes I Teach</size></color></align><br>CSIS180: Web Design, CSIS110: Introduction to Computer Science, CSIS200: Diversity in Computer Science<br><align=\"center\"><color=#006B54><size=26px>Clubs</size></color></align><br>Women in Computing.  This club is a great way to involve and engage women in the computer science field. We provide valuable networking between Siena students and successful career professionals by encouraging attendance to various computer science conferences.<br><br><align=\"center\"><color=#006B54><size=26px>Hobbies + Interests</size></color></align><br>Dr. Egan likes to travel, so much so she has been to all 7 continents. She also enjoys movies, crafts, cool new tech and her grandkids. Her favorite play is <i>Hamilton</i>";
            break;
            case "RB332":
                global_TextForNewScene = "RB332";
            break;
            case "RB328":
                global_TextForNewScene = "RB328";
            break;
            case "RB326":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Dr. Ting Liu</size></color></align><br>With research interests in Computational Sociolinguistics, Natural Language Processing, AI and Machine Learning, Dr. Liu is the one to go to to ask about the ever changing world of Computer Science. His current area of research is on general AI, which teaches robots to learn like kids.<br><br>\"I really enjoy teaching in the class and working with my students during the research. We have very dedicated and intelligent students, who clearly know their goals and responsibilities to the society and therefore are willing to put their time and efforts into preparing for their brilliant future. I also very much enjoy working with my colleagues. We not only share the ideas and experiences to improve the teaching/learning quality but also collaborate tightly to work on the very challenging research problems in Computer Science area.\"<br><align=\"center\"><color=#006B54><size=26px>Classes I Teach</size></color></align><br>CSIS120: Software Development, CSIS210: Data Structures, CSIS370: Robotics, CSIS375: Intro to AI";
            break;
            case "RB324":
                global_TextForNewScene = "RB324";
            break;
            case "RB323":
                global_TextForNewScene = "<align=\"center\"><color=#006B54><size=28px>Professor James Matthews</size></color></align><br>Most every Computer Science student will have to take math classes, and they'll most likely take them with Professor Matthews. His high enthusiasm for mathematics will leave students with many fond memories from his classes.<br><br>Outside of the classroom, Professor Matthews focuses on STEM Education. He is a national leader in Math and Computer Science education and is a monumental part of organizing the yearly High School Programming event, where teams of high school students come to Siena for friendly competition.<br><align=\"center\"><color=#006B54><size=26px>Classes I Teach</size></color></align><br><br>MATH010: Finite Mathematics, MATH250: Discrete Mathematics, MATH350: Theory of Computation, CSIS110: Intro to Computer Science<br><br><align=\"center\"><color=#006B54><size=26px>Hobbies + Interests</size></color></align><br>Professor Matthews likes to run, bike, hike and ski. He also enjoys puzzles and games, magic, reading and hanging out with his friends and families.";
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