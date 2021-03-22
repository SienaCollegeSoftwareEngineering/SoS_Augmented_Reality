using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralSceneChanger : MonoBehaviour
{
    public Object sceneObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartScene()
    {
        SceneManager.LoadScene(sceneObject.name);
    }
}
