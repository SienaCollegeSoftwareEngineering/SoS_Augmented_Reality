using System.Collections;
using System.Collections.Generic;   
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;

public class MoreInfo : MonoBehaviour
{
    //Variables for the text in the More Info Scene
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
    * This function is used to get the data from the database and display it on the More Info Scene
    */
    IEnumerator Start()
    {
        WWWForm form = new WWWForm();
        // string test = "RB319";
        form.AddField("roomNumber", ModifyInfoButton.global_RoomNum);
        
        WWW request = new WWW("https://soswebform.uk.r.appspot.com/getData.php", form);
        

        yield return request;
        
        // int indexOf = Str.IndexOf(request.text, " ");
        
        //Gtes rid of all the unneeded text from the database
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

        //Splits the string into an array of strings
        string[] data = str.Split('>');
        
        foreach(string item in data){
            Debug.Log(item);
        }

        //Putting elements of the text from the database into variables
        ProfNameForNewScene = data[2].Replace(" ","")+" "+data[3].Replace(" ","")+" "+data[4].Replace(" ","");
        ProfDepartmentForNewScene = data[6];
        TextForNewScene = data[7];
        
        Debug.Log(request.text);

        //Updates the text in the More Info Scene
        GameObject.Find("Content").GetComponent<TMP_Text>().text = TextForNewScene;
        GameObject.Find("ProfessorName").GetComponent<TMP_Text>().text = ProfNameForNewScene;
        GameObject.Find("Department").GetComponent<TMP_Text>().text = ProfDepartmentForNewScene;
        
    }

    //What is triggered when the back button is clicked, sends user back to the previous page they were on
    public void BackButton()
    {
        Debug.Log("Here");
        GameObject.Find("Content").GetComponent<TMP_Text>().text = "";
        GameObject.Find("ProfessorName").GetComponent<TMP_Text>().text = "Loading";
        GameObject.Find("Department").GetComponent<TMP_Text>().text = "";
        SceneManager.LoadScene(ClassroomMenu.global_whereFrom);
        
    }

}
