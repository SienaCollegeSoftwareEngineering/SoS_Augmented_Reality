using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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
        Label moreInfoText = root.Q<Label>("InfoText");
        Label professorNameText = root.Q<Label>("ProfName");
        Label profDepartmentText = root.Q<Label>("ProfDepartment");
        IMGUIContainer profImage = root.Q<IMGUIContainer>("ProfImage");

        //When the back button is clicked load the roger bacon scene.
        backButton.clicked += () => SceneManager.LoadScene("RogerBacon");

        //Update text based on info recieved from ModifyInfoButton script
        moreInfoText.text = ModifyInfoButton.global_TextForNewScene;
        professorNameText.text = ModifyInfoButton.global_ProfNameForNewScene;
        profDepartmentText.text = ModifyInfoButton.global_ProfDepartmentForNewScene;
        profImage.style.backgroundImage = AssetDatabase.LoadAssetAtPath<Texture2D>(ModifyInfoButton.global_ProfImageForNewScene);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
