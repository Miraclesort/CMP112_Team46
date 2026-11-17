using TMPro;
using UnityEngine;

public class finish : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI victory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            victory.text = "You Win!";
        }
    }
}
