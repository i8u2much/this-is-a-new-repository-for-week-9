using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;

    ScoreKeeper scoreKeeper;

    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = gameObject.GetComponent<ScoreKeeper>();
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreKeeper.score.ToString();
    }


}
