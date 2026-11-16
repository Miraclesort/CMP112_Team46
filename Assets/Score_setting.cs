using JetBrains.Annotations;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Score_setting : MonoBehaviour
{
    public TextMeshProUGUI bananaText;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Sets the ui element to the current score of the player
        bananaText.text = Pickup.score.ToString();
    }
}
