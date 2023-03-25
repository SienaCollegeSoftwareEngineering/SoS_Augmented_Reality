using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using TMPro;


public class Manager : MonoBehaviour
{
    // 3/25/2023 - Commenting this script out because 1. I don't know what it does as I did not
    // write it, 2. It gives an error when running in game, 3. it is unncessary
    /*
     private TMP_Text m_TextComponent;

     //I know this looks bad but I don't know exactly how the data comes in from the new database
     public StringBuilder allData;
    void Start()
    {
        // A correct website page.
        
        StartCoroutine(GetRequest("api.openweathermap.org/data/2.5/weather?lat=42.7188&lon=73.7510&appid=22f5b802765d94bb090be2f232637dc4"));
    }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                    Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                    break;
            }
            Parse(webRequest.downloadHandler.text);
        }
    }
        void Parse(string data){
            JsonTextReader reader = new JsonTextReader(new StringReader(data));
            while (reader.Read())
            {
                if (reader.Value != null)
                {
                        allData.Append(reader.Value);
                    }
                }
            }
    */
}