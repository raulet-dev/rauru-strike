using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private int score;

    private Text text;

    public GameObject scObj;

    void Awake()
    {
    	text = GetComponent<Text>();
        DontDestroyOnLoad(scObj);
    }
    
    void InitScore()
    {
    	this.score = 0;
    	UpdateText();
    }

    void AddScore(int sc)
    {
        
    	this.score += sc;
        UpdateText();
    }

    void UpdateText()
    {
    	text.text = "Score:" + this.score;
    }

   
}
