using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    ScoreKeeper score;
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<ScoreKeeper>();
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        print(col.gameObject.name + "trigger");

        if (col.gameObject.name == "Player")
        {
           
            // call the score
            Destroy(this.gameObject);
        }
    }

}
