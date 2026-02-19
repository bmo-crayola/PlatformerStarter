using UnityEngine;

public class QuestionCycle : MonoBehaviour
{
    public Material questionBlockMaterial;
    public float animationSpeed = 5f;
    public int totalFrames = 5; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        questionBlockMaterial.mainTextureScale = new Vector2(-1f, -0.2f);

    }

    // Update is called once per frame
    void Update()
    {
        float frame = Mathf.Floor(Time.time * animationSpeed) % totalFrames;
        float yOffset = frame * (1f / totalFrames);

        questionBlockMaterial.mainTextureOffset = new Vector2(0f, yOffset);
    }
}
