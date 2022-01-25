using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void loadCameraScene()
    {
        SceneManager.LoadScene("CameraScreen");
    }

    public void exitApp()
    {
        Application.Quit();
        Debug.Log("App has been quit.");
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("TitleScreen");
}
}
