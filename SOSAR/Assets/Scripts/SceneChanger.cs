using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Utilizes the SceneManagement import, manages how scenes
 * are changed. Can be used as a prefab or as a instance in
 * a scene to call the script.
 * 
 * Author(s): SoS Team Spring 2023
 * 
 */
public class SceneChanger : MonoBehaviour
{
    /*
     * On Awake, make the object persistent
     */
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    /*
     * Change the scene using LoadScene();
     * 
     * Arguments: 
     *      sceneName: The string name of the 
     *      scene to change to
     * 
     */
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
