using System.Collections;
using System.Collections.Generic;
//using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MoreInfo : MonoBehaviour
{
    public MoreInfo moreInfo;
    public string TextForNewScene;
    public string ProfNameForNewScene;
    public string ProfDepartmentForNewScene;
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
    IEnumerator Start()
    {
        WWWForm form = new WWWForm();
        string test = "RB319";
        form.AddField("roomNumber", test);
        
        WWW request = new WWW("https://soswebform.uk.r.appspot.com/getData.php", form);
        

        yield return request;
        TextForNewScene = request.text;
        Debug.Log(request.text);
       
        
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        
        //Get the elements of the UI
        Button backButton = root.Q<Button>("backButton");
        Label moreInfoText = root.Q<Label>("InfoText");
        Label professorNameText = root.Q<Label>("ProfName");
        Label profDepartmentText = root.Q<Label>("ProfDepartment");
        IMGUIContainer profImage = root.Q<IMGUIContainer>("ProfImage");

        //When the back button is clicked load the roger bacon scene.
        backButton.clicked += () => SceneManager.LoadScene("RogerBacon");

        //Update text based on info recieved from DatavaseConnection script
        moreInfoText.text = TextForNewScene;
        professorNameText.text = ProfNameForNewScene;
        profDepartmentText.text = ProfDepartmentForNewScene;
        //profImage.style.backgroundImage = AssetDatabase.LoadAssetAtPath<Texture2D>(ModifyInfoButton.global_ProfImageForNewScene);
        
    }

}
