using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public bool global_accessibilityEnabled = true;
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
    public void LoadInfoScene()
    {
        Debug.Log("Load Info Scene");
        SceneManager.LoadScene("InfoScreen");
    }

    public void OpenURL()
    {
        Application.OpenURL("https://soswebform.uk.r.appspot.com/PrivacyPolicy.php");
    }

    public void disableAccessibility()
    {
        UAP_AccessibilityManager.EnableAccessibility(false);	
    }

}
