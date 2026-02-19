using UnityEngine;
using TMPro;

public class RaycastingOnClick : MonoBehaviour
{
    public Camera camera;
    public TextMeshProUGUI coinText;

    private int coins = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo)) {
                if (hitInfo.collider.CompareTag("Question")) {
                    coins++;
                    coinText.text = "x" + coins.ToString("D2");
                } else if (hitInfo.collider.CompareTag("Brick")) {
                    Destroy(hitInfo.collider.gameObject);
                }
            }
        }
    }
}
