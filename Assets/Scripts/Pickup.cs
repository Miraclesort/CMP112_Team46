using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public static int score;
    int getScore()
    {
        return score;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        score++;
    }


}
