using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


/**
 * Description: add this to an image target that is going to change the global/static variable to indicate what object is going to be
 * shown next.
 * 
 * @author Nick Giordano
 * @date 04/12/21
 * 
 */

public class ClueIndicator : MonoBehaviour
{
    //current name
    public string previousMajorName = " ";
    //new name
    public string newMajorName = " ";
    //things to do when name changes
    public UnityEvent clueSceneScriptList = new UnityEvent();
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        if (ChooseMajor.initalMajorName == previousMajorName)
        {
            //executes events(button OnClick section) and changes global variable
            clueSceneScriptList.Invoke();
            ChooseMajor.initalMajorName = newMajorName;

        }
        //Debug.LogError(ChooseMajor.initalMajorName + " " + newMajorName);
    }
}
