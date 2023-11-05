using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePointer : MonoBehaviour
{
    public GameObject objetoAActivar;
    public Color colorAlColisionar = Color.red; // Establecer el color de colisión como rojo
    private Renderer rend;
    private Color colorOriginal;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        colorOriginal = rend.material.color; // Guardar el color original al inicio
    }

    void Update()
    {
        // Verifica si se ha presionado la tecla P
        if (Input.GetKeyDown(KeyCode.P))
        {
            // Cambia el estado activo/inactivo del objeto
            objetoAActivar.SetActive(!objetoAActivar.activeSelf);
            Debug.Log("Se presionó la tecla P");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Cambiar el color del objeto cuando colisiona con otro objeto
        rend.material.color = colorAlColisionar;
        Debug.Log("Colisionó con " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        // Restaurar el color original al dejar de colisionar
        rend.material.color = colorOriginal;
        Debug.Log("Dejó de colisionar con " + collision.gameObject.name);
    }
}
