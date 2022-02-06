using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadCameraScene()
    {
        Debug.Log("Load Camera Scene");
        SceneManager.LoadScene("CameraScreen");
    }

    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("App has been quit.");
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("TitleScreen");
}
}
