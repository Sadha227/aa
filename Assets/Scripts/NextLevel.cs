using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    void Start()
    {
        int passedSceneIndex = PlayerPrefs.GetInt(Level.NEXT_LEVEL_KEY, Level.LEVEL_TO_START);
        text.text = "Next level " + passedSceneIndex.ToString();
    }
}
