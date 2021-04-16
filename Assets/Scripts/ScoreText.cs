using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    private int pinNumber;

    void Start() { pinNumber = FindObjectOfType<Managar>().GetTotalNumberOfPins(); }

    void Update() { text.text = pinNumber.ToString(); }

    public void ChangeNumberOfPins() { pinNumber--; }
}
