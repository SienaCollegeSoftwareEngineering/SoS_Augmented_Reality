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

    public Image XButtonClueImg;

    public Button XButtonClue;

    public Image cluePanel;

    public TMP_Text nextClue;
    public Button XButton;
    public TMP_Text clueText;

    public TMP_Text coinCounter;

    public static string global_PlaqueInfo;

    public int coinCount = 0;

    public bool usedHint = false;

    public bool gameStarted = true;
    

    //public List<string> plaqueNums = new List<string> { "RB308", "RB311", "RB313", "RB314", "RB315", "RB316", "RB317", "RB318", "RB319", "RB320", "RB321", "RB323"};

    //public List<string> plaqueHints = new List<string> { "Teresco", "Small", "Vandenberg", "DiTursi", "Flatland", "Lim", "Goldstein", "Small", "Cotler", "Breimer", "Armitage", "Matthews"};

    public static string[] plaqueNums = {"RB323","RB313", "RB321", "RB308", "RB311", "RB332", "RB315", "RB316", "RB317", "RB318", "RB319", "RB320","RB338","RB326" };
    public static string[] plaqueClues = {
        "This professor teaches Discrete Structures and their office is located near Room 350", 
        "This professor’s favorite class to teach is Database Management Systems and their office is located near Room 328",
        "This professor is the advisor of the Cyber Security club and their office is located near Room 350", 
        "This professor is the head chair of the computer science department", 
        "This is the only professor to teach CSIS 220 and their by the CS lounge", 
        "This professor is near 340 and teaches Intro to Computer Science and Software Engineering", 
        "This professor teaches Algorithms and Intro to Computer Science, and their office is located across from Room 328", 
        "This is the only professor who teaches a first year seminar course", 
        "This is the only professor to teach Networking and Unix/Linux",
        "This professor’s research and teaching areas are Artificial Intelligence and Computational Linguistics", 
        "This professor teaches UX Design and Software Engineering", 
        "This professor teaches intro to data science",
        "This professor is the only one to teach Web Design",
        "This professor does research about Natural language processing"
    };
    public static string[] plaqueHints = {
        "He is not Jack Armitage", 
        "Their plaque says they attended University of Wisconsin-Madison for their PHD", 
        "He is known as the dopey IT guy", 
        "Their plaque says the love to ski", 
        "She has a M.A.T. from Union Graduate College", 
        "He was a professional athlete on the Indian National Rifle Shooting Team", 
        "She loves cooking and distance swimming", 
        "They love to participate in trivia", 
        "One of his photos was chosen for Wikipedia picture of the day", 
        "This professor is located in the CS Lounge", 
        "This professor is across from the Software Engineering Lab", 
        "They love to kayak and row",
        "She has been to all 7 continents", 
        "He got his masters and bachelors degree from Shandong University"
    };

    public int current_Plaque = 0;


    void Awake(){
        current_Plaque = 0;
        coinCount = 0;
        
    }

    public void SelfTour(){
        pnl = GameObject.Find("RBButtons").GetComponent<Image>();
        pnl.enabled = false;
        clueText = GameObject.Find("SelfTourButton/SelfTourButtonText").GetComponent<TMP_Text>();
        clueText.enabled = false;
        btn = GameObject.Find("SelfTourButton").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("SelfTourButton").GetComponent<Image>();
        img.enabled = false;
        clueText = GameObject.Find("SelfTourButtonText").GetComponent<TMP_Text>();
        clueText.enabled = false;
        btn = GameObject.Find("ScavengerHuntButton").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("ScavengerHuntButton").GetComponent<Image>();
        img.enabled = false;
        
        clueText = GameObject.Find("SienaText").GetComponent<TMP_Text>();
        clueText.enabled = false;
    }
    public void DeactivateGame(){
        gameStarted = false;
    }
    public void ActivateGame(){
        pnl = GameObject.Find("RBButtons").GetComponent<Image>();
        pnl.enabled = false;
        //clueText = GameObject.Find("SelfTourButtonText").GetComponent<TMP_Text>();
        //clueText.enabled = false;
        btn = GameObject.Find("SelfTourButton").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("SelfTourButton").GetComponent<Image>();
        img.enabled = false;
        //clueText = GameObject.Find("ScavengerHuntButtonText").GetComponent<TMP_Text>();
        //clueText.enabled = false;
        btn = GameObject.Find("ScavengerHuntButton").GetComponent<Button>();
        btn.enabled = false;
        img = GameObject.Find("ScavengerHuntButton").GetComponent<Image>();
        img.enabled = false;
        
        clueText = GameObject.Find("SienaText").GetComponent<TMP_Text>();
        clueText.enabled = false;
            Debug.Log("Game Activated");
            clueText = GameObject.Find("CoinCounter").GetComponent<TMP_Text>();
            clueText.enabled = true;
            img = GameObject.Find("Coin").GetComponent<Image>();
            img.enabled = true;
            pnl = GameObject.Find("CoinBackground").GetComponent<Image>();
            pnl.enabled = true; 
            btn = GameObject.Find("ClueButton").GetComponent<Button>();
            btn.enabled = true;
            clueText = GameObject.Find("ClueButtonText").GetComponent<TMP_Text>();
            clueText.enabled = true;
            img = GameObject.Find("ClueButton").GetComponent<Image>();
            img.enabled = true;

        gameStarted = true;
    }
    public void GetCurrentPlaque(string plaqueInfo)
    {
        //if(gameStarted){
            global_PlaqueInfo = plaqueInfo;
            Debug.Log("Check for me: " + global_PlaqueInfo);
            checkPlaque();
        //}

    }

    public void checkPlaque()
    {
        Debug.Log("Check for me2: " + global_PlaqueInfo);
        if (current_Plaque != 14)
        {
            if (string.Equals(global_PlaqueInfo, plaqueNums[current_Plaque]))
            {
                Debug.Log("Correct Plaque");
                //plaqueNums.RemoveAt(current_Plaque);
                //plaqueHints.RemoveAt(current_Plaque);
                if (current_Plaque == 14)
                {
                    Debug.Log("Won Game");
                }
                else
                {
                    if(usedHint == false)
                    {
                        coinCount++;
                        incrementCoin(); 
                    }
                    else{
                        usedHint = false;
                    }
                    
                    newPlaque();
                    displayClue();
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
        //current_Plaque = Random.Range(0, plaqueNums.Count-1);

        current_Plaque++;
        
        Debug.Log(current_Plaque);
    }

    public void displayCurrentHint()
    {
        

        clueText = GameObject.Find("ClueText").GetComponent<TMP_Text>();
        clueText.enabled = true;
        clueText.text = plaqueHints[current_Plaque];

        XButton = GameObject.Find("XButton").GetComponent<Button>();
        XButton.enabled = true;

        img = GameObject.Find("XButton").GetComponent<Image>();
        img.enabled = true;

        pnl = GameObject.Find("ClueBackground").GetComponent<Image>();
        pnl.enabled = true;
        usedHint = true;
    }

    public void displayCurrentClue()
    {
        nextClue = GameObject.Find("NextClue").GetComponent<TMP_Text>();
        nextClue.text = plaqueClues[current_Plaque];
        nextClue.enabled = true;

        cluePanel = GameObject.Find("NextClueBackground").GetComponent<Image>();
        cluePanel.enabled = true;

        XButtonClue = GameObject.Find("XButtonClue").GetComponent<Button>();
        XButtonClue.enabled = true;

        XButtonClueImg = GameObject.Find("XButtonClue").GetComponent<Image>();
        XButtonClueImg.enabled = true;
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


    public void incrementCoin()
    {
        
        coinCounter = GameObject.Find("CoinCounter").GetComponent<TMP_Text>();
    
        string coinCountText = coinCount.ToString();
        coinCounter.text = coinCountText;
        Debug.Log(coinCount);
    }

    public void displayClue()
    {
        nextClue = GameObject.Find("NextClue").GetComponent<TMP_Text>();
        nextClue.text = plaqueClues[current_Plaque];
        nextClue.enabled = true;

        cluePanel = GameObject.Find("NextClueBackground").GetComponent<Image>();
        cluePanel.enabled = true;

        XButtonClue = GameObject.Find("XButtonClue").GetComponent<Button>();
        XButtonClue.enabled = true;

        XButtonClueImg = GameObject.Find("XButtonClue").GetComponent<Image>();
        XButtonClueImg.enabled = true;
    }

    public void hideClue(){
        nextClue = GameObject.Find("NextClue").GetComponent<TMP_Text>();
        nextClue.enabled = false;

        cluePanel = GameObject.Find("NextClueBackground").GetComponent<Image>();
        cluePanel.enabled = false;

        XButtonClue = GameObject.Find("XButtonClue").GetComponent<Button>();
        XButtonClue.enabled = false;

        XButtonClueImg = GameObject.Find("XButtonClue").GetComponent<Image>();
        XButtonClueImg.enabled = false;
    }
    
}