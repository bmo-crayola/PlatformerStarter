using UnityEngine;
using TMPro;

public class TimeController : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    float timeLeft = 400;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime * 1.5f;
        timeText.text = $"TIME\n{((int)timeLeft).ToString()}";
    }
}
