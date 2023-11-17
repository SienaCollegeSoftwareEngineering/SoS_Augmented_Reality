using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class ScavengerHunt : MonoBehaviour
{
    public Button btn;

    public Image pnl;
    public Image img;
    public Button XButton;
    public TMP_Text clueText;

    public static string global_PlaqueInfo;


    

    public List<string> plaqueNums = new List<string> { "RB308", "RB311", "RB313", "RB314", "RB315", "RB316", "RB317", "RB318", "RB319", "RB320", "RB321", "RB323"};

    public List<string> plaqueHints = new List<string> { "Teresco", "Small", "Vandenberg", "DiTursi", "Flatland", "Lim", "Goldstein", "Small", "Cotler", "Breimer", "Armitage", "Matthews"};

    public int current_Plaque = 0;



    public void GetCurrentPlaque(string plaqueInfo)
    {
        global_PlaqueInfo = plaqueInfo;
        Debug.Log(global_PlaqueInfo);
        checkPlaque();

    }

    public void checkPlaque()
    {
        if (plaqueHints.Count != 0)
        {
            if (string.Equals(global_PlaqueInfo, plaqueNums[current_Plaque]))
            {
                Debug.Log("Correct Plaque");
                plaqueNums.RemoveAt(current_Plaque);
                plaqueHints.RemoveAt(current_Plaque);
                if (plaqueHints.Count == 0)
                {
                    Debug.Log("Won Game");
                }
                else
                {
                    newPlaque();
                }
            }
            else
            {
                Debug.Log("Incorrect Plaque");
            }
        }
    }

    public void newPlaque()
    {
        current_Plaque = Random.Range(-1, plaqueNums.Count);
        Debug.Log(current_Plaque);
    }

    public void displayCurrentHint()
    {
        string hint;
        hint = plaqueNums[current_Plaque];
        Debug.Log(hint);
        clueText = GameObject.Find("ClueText").GetComponent<TMP_Text>();
        clueText.enabled = true;
        clueText.text = plaqueHints[current_Plaque];

        XButton = GameObject.Find("XButton").GetComponent<Button>();
        XButton.enabled = true;

        img = GameObject.Find("XButton").GetComponent<Image>();
        img.enabled = true;

        pnl = GameObject.Find("ClueBackground").GetComponent<Image>();
        pnl.enabled = true;
    }

    public void hideCurrentHint()
    {
        clueText = GameObject.Find("ClueText").GetComponent<TMP_Text>();
        clueText.enabled = false;

        XButton = GameObject.Find("XButton").GetComponent<Button>();
        XButton.enabled = false;

        img = GameObject.Find("XButton").GetComponent<Image>();
        img.enabled = false;

        pnl = GameObject.Find("ClueBackground").GetComponent<Image>();
        pnl.enabled = false;
    }


}