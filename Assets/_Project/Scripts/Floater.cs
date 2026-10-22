using UnityEngine;

public class Floater : MonoBehaviour
{
    [Tooltip("Ampiezza dell'oscillazione in unità Unity")]
    [SerializeField] private float amplitude = 0.25f;

    [Tooltip("Velocità dell'oscillazione (cicli al secondo)")]
    [SerializeField] private float frequency = 0.5f;

    private Vector3 startLocalPosition;

    private void Start()
    {
        startLocalPosition = transform.localPosition;
    }

    private void Update()
    {
        float offset = Mathf.Sin(Time.time * frequency * Mathf.PI * 2f) * amplitude;
        transform.localPosition = startLocalPosition + Vector3.up * offset;
    }
}