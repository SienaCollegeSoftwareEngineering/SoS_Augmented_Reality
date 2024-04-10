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
        // string test = "RB319";
        form.AddField("roomNumber", ModifyInfoButton.global_RoomNum);
        
        WWW request = new WWW("https://soswebform.uk.r.appspot.com/getData.php", form);
        

        yield return request;
        
        // int indexOf = Str.IndexOf(request.text, " ");
        
        string str = request.text;
        str= str.Replace("Array", "");
        str= str.Replace("(", "");
        str= str.Replace(")", "");
        str= str.Replace("[email]", "");
        str= str.Replace("[prefix]", "");
        str= str.Replace("[fname]", "");
        str= str.Replace("[lname]", "");
        str= str.Replace("[department]", "");
        str= str.Replace("[description]", "");
        str= str.Replace("[roomnum]", "");
        str= str.Replace("=", "");
        str= str.Replace("\n", "");
        str= str.Replace("\r", "");

        string[] data = str.Split('>');
        //  Debug.Log(data.ToString());
        foreach(string item in data){
            Debug.Log(item);
        }
    
        ProfNameForNewScene = data[2].Replace(" ","")+" "+data[3].Replace(" ","")+" "+data[4].Replace(" ","");
        ProfDepartmentForNewScene = data[6];
        TextForNewScene = data[7];
        // TextForNewScene = request.text;
        Debug.Log(request.text);
       
        
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        
        //Get the elements of the UI
        Button backButton = root.Q<Button>("backButton");
        Label moreInfoText = root.Q<Label>("InfoText");
        Label professorNameText = root.Q<Label>("ProfName");
        Label profDepartmentText = root.Q<Label>("ProfDepartment");
        IMGUIContainer profImage = root.Q<IMGUIContainer>("ProfImage");

        //When the back button is clicked load the roger bacon scene.
        backButton.clicked += () => SceneManager.LoadScene(Dropdown.global_whereFrom);

        //Update text based on info recieved from DatavaseConnection script
        moreInfoText.text = TextForNewScene;
        professorNameText.text = ProfNameForNewScene;
        profDepartmentText.text = ProfDepartmentForNewScene;
        //profImage.style.backgroundImage = AssetDatabase.LoadAssetAtPath<Texture2D>(ModifyInfoButton.global_ProfImageForNewScene);
        
    }

}
