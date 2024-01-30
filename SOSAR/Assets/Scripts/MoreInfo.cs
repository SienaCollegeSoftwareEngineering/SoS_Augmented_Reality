using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MoreInfo : MonoBehaviour
{
    public MoreInfo moreInfo;

    /*
     * On Awake, make the object persistent
     */
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    /*
    * Start is called before the first frame update
    */
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        
        //Get the elements of the UI
        Button backButton = root.Q<Button>("backButton");
        VisualElement moreInfoText = root.Q<VisualElement>("InfoText");

        //When the back button is clicked load the roger bacon scene.
        backButton.clicked += () => SceneManager.LoadScene("RogerBacon");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
