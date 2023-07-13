using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI TextScoreUI;
    void Start()
    {
        SetUISCore(TimeManager.Day);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetUISCore(int score){
        TextScoreUI.text = score.ToString ();
    }
}
