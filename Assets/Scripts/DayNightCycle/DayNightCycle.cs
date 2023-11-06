using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public float dayLength = 600; // Duración de un día en segundos
    public Transform sunTransform; // Asigna el objeto "Directional Light" al Inspector

    private float timeOfDay = 0;
    private float rotationSpeed;

    void Start()
    {
        rotationSpeed = 360f / dayLength; // Calcula la velocidad de rotación
    }

    void Update()
    {
        timeOfDay += Time.deltaTime;
        if (timeOfDay > dayLength)
        {
            timeOfDay = 0;
        }

        // Calcula la rotación en función del tiempo del día
        float angle = (timeOfDay / dayLength) * 360f;

        // Gira el objeto "Directional Light" en el eje X
        sunTransform.rotation = Quaternion.Euler(angle, 0, 0);
    }
}
