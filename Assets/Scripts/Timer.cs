using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI timertext;
    [SerializeField] TextMeshProUGUI victorytext;
    [SerializeField]float elapsedtime = 180;
    // Update is called once per frame
    void Update()
    {
        elapsedtime -= Time.deltaTime;

        timertext.text = elapsedtime.ToString();
        if (elapsedtime < 0 )
        {
            victorytext.text = "You Lost :(";
            timertext.text = "0";
        }
    }
}
