using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TextHover : MonoBehaviour
{
    public Text hoveredText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Cambia el color del texto del botón cuando el puntero pasa sobre él
        hoveredText.color = Color.white;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Restaura el color normal del texto del botón cuando el puntero sale de él
        hoveredText.color = Color.red;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
