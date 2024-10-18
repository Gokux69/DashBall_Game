using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class healthmanager : MonoBehaviour
{
    public static int health = 3;
    public Image[] heart;
    public Sprite fullheart;
    public Sprite emptyheart;


    // Update is called once per frame
    void Update()
    {
        foreach (Image img in heart)
        {
            img.sprite = emptyheart;
            for (int i = 0; i < health; i++)
            {
                heart[i].sprite = fullheart;
            }
        }
    }
}
