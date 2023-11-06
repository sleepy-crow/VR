using UnityEngine;
using UnityEngine.UI;

public class LightController : MonoBehaviour
{
    public GameObject[] lights; // Asigna las luces que deseas encender/apagar en el Inspector
    public Button toggleButton; // Asigna el botón en el Inspector

    private bool lightsOn = true;

    void Start()
    {
        toggleButton.onClick.AddListener(ToggleLights);
    }

    void ToggleLights()
    {
        lightsOn = !lightsOn;

        foreach (GameObject light in lights)
        {
            light.SetActive(lightsOn);
        }
    }
}
