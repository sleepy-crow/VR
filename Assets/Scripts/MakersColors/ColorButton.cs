using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    public ColorData colorData;
    public GameObject targetObject; // Asigna el GameObject en el Inspector

    private Image buttonImage;

    private void Start()
    {
        buttonImage = GetComponent<Image>();
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        colorData.color = buttonImage.color;

        Renderer renderer = targetObject.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = colorData.color;
        }
    }
}
