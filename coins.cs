using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coins : MonoBehaviour
{

    public int coin;
    public Text MyScoreText;
    private int score;
    public AudioClip coinSound;
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "coin")
        {
            
            coin = coin + 1;
            score += 1;
            MyScoreText.text = "Coins :" + score; 
           AudioSource.PlayClipAtPoint(coinSound, transform.position);
            col.gameObject.SetActive(false);

        }
    }
    void Start()
    {
        score = 0;
        MyScoreText.text = "Coins :" + score; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
