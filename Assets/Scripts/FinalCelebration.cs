using UnityEngine;

// Evento final: enciende una luz y cambia el color del objeto meta.
public class FinalCelebration : MonoBehaviour
{
    [SerializeField] private Light goalLight;
    [SerializeField] private Renderer goalRenderer;
    [SerializeField] private ParticleSystem confetti;

    public void Celebrate()
    {
        if (goalLight) goalLight.enabled = true;
        if (goalRenderer) goalRenderer.material.color = Color.green;
        if (confetti) confetti.Play();
        Debug.Log("Rube Goldberg completado!");
    }
}
