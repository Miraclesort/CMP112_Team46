using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    //initialize score as public and static so it can be accessed by the score_setting class and changed every time the player collects a collectable
    public static int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        //checks if the collision is with the player
        if (collider.gameObject.tag == "Player")
        {
            //destroys the collectable object and adds one to the score when colliding with the player
            Destroy(gameObject);
            score++;
        }
        else
        {

        }
    }


}
