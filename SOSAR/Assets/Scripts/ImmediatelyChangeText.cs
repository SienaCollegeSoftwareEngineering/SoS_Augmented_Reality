using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ImmediatelyChangeText : MonoBehaviour
{
    public TMP_Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = GameObject.Find("Content").GetComponent<TMP_Text>();
        _text.text = ModifyInfoButton.global_TextForNewScene;
    }
}