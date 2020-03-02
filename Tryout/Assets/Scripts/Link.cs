using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{
    public void OpenCS()
    {
        Application.OpenURL("https://www.siena.edu/departments/computer-science/");
    }

    public void OpenSoftDev()
    {
        Application.OpenURL("https://www.siena.edu/programs/software-development/");
    }

    public void OpenInfoSys()
    {
        Application.OpenURL("https://www.siena.edu/programs/information-systems/");
    }
}
