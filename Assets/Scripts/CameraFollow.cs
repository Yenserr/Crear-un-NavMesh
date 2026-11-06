using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El Player
    public Vector3 offset = new Vector3(0, 12, -8); // Distancia y altura de la cámara

    [Header("Límites de la Cámara (Límites del Almacén)")]
    public bool usarLimites = true;
    public float minX = -10f;
    public float maxX = 10f;
    public float minZ = -10f;
    public float maxZ = 10f;

    void LateUpdate()
    {
        if (target == null) return;

        // Calculamos la posición ideal
        Vector3 targetPosition = target.position + offset;

        // Si activamos los límites, restringimos la posición dentro del almacén
        if (usarLimites)
        {
            targetPosition.x = Mathf.Clamp(targetPosition.x, minX, maxX);
            targetPosition.z = Mathf.Clamp(targetPosition.z, minZ, maxZ);
        }

        // Movemos la cámara a la posición calculada
        transform.position = targetPosition;
    }
}