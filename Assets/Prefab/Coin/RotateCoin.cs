using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float speed = 2.0f; // скорость вращени€
    public float maxRotation = 10.0f; // максимальна€ амплитуда вращени€

    private float initialZRotation;

    void Start()
    {
        initialZRotation = transform.eulerAngles.z;
    }

    void Update()
    {
        // ¬ычисл€ем угол на основе синусоиды
        float zRotation = initialZRotation + maxRotation * Mathf.Sin(Time.time * speed);
        // ѕримен€ем вращение вокруг оси Z
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, zRotation);
    }
}