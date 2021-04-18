using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class cameraClueAppear : MonoBehaviour
{
    //events to change text
    public UnityEvent clueCameraScriptList = new UnityEvent();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateText()
    {
        clueCameraScriptList.Invoke();
    }
}
