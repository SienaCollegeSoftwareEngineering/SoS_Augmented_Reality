using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Can be used at a potential loading screen 
 * to load in things such as persistent objects
 * only once. The amount of time waited can be
 * adjusted in the editor
 * 
 * Author(s): SoS Team Spring 2023
 * 
 */
public class Wait : MonoBehaviour
{
    // Amount of time, in seconds, that you wait
    public int Time;
    // SceneChanger object that is used here to change to the TitleScreen
    public SceneChanger sceneChanger;

    /*
     * When instance is created, this is called on the first frame
     */
    public void Start()
    {
        StartCoroutine(wait());
    }

    /*
     * Wait for x seconds, then go on to TitleScreen
     */
    IEnumerator wait()
    {
        yield return new WaitForSeconds(Time);
        sceneChanger.ChangeScene("TitleScreen");
    }
}
