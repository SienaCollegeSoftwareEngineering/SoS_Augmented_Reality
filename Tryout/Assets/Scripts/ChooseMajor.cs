using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

/**
 * Description: add to button object to make sure the chosen scene loads. This is based on 2 lists: 1
 * to check what radio buttons are enabled, and the other to load the associated scene.
 * 
 * @author Nick Giordano
 * @Date: 21/04/11
 * 
 */
public class ChooseMajor : MonoBehaviour
{
    //global static variable
    public static string initalMajorName = "";
    //array of check mark objects from radio button objects in here
    public GameObject[] buttonCheckMarks;
    //array of unity events for each check mark object to execute(similar to OnClick from buttons)
    public UnityEvent[] sceneScriptList = new UnityEvent[8];
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // This function checks the check mark objects are active/enabled. Then sets
    // the global variable to work with the major selected 
    public void checkMajors()
    {
        //checks for computer science checkmark 
        if(buttonCheckMarks[2].activeSelf == true )
        {
            //executes events(button OnClick section) and changes global variable
            sceneScriptList[2].Invoke();
            initalMajorName = "ComputerScience";
        }
    }
}
