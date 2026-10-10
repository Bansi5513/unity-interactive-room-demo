using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light roomLight;
    public Color[] lightColors;
    private int currentColor = 0;
    private bool playerNearby = false;

    void Start()
    {
        lightColors = new Color[]
        {
            new Color(1f, 0.94f, 0.78f),
            new Color(1f, 0.3f, 0.3f),
            new Color(0.3f, 0.6f, 1f),
            new Color(0.3f, 1f, 0.5f),
            new Color(0.8f, 0.3f, 1f)
        };
    }

    void Update()
    {
        if (playerNearby && Input.GetKeyDown(KeyCode.F))
        {
            currentColor = (currentColor + 1) % lightColors.Length;
            roomLight.color = lightColors[currentColor];
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            playerNearby = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            playerNearby = false;
    }
}