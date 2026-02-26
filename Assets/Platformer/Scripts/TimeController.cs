using UnityEngine;
using TMPro;

public class TimeController : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    float timeLeft = 5;
    bool timeUp = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeUp) return;
        timeLeft -= Time.deltaTime * 1.5f;
        timeText.text = $"TIME\n{((int)timeLeft).ToString()}";
        if (timeLeft <= 0) {
            timeText.text = "TIME\n0";
            Debug.Log("The Player ran out of time!");
            timeUp = true;
        }
    }
}
