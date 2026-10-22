using UnityEngine;

// Opcional: registra choques fuertes (util para depurar y para sonido).
public class CollisionLogger : MonoBehaviour
{
    [SerializeField] private float minImpact = 1.5f;
    [SerializeField] private AudioSource hitSound;

    void OnCollisionEnter(Collision c)
    {
        float impact = c.relativeVelocity.magnitude;
        if (impact < minImpact) return;
        Debug.Log($"{name} choco con {c.gameObject.name} (impacto {impact:F1} m/s)");
        if (hitSound) hitSound.Play();
    }
}
