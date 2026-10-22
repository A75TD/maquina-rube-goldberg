using UnityEngine;
using UnityEngine.Events;

// Zona invisible (Is Trigger) que dispara un evento cuando entra un objeto con el tag indicado.
[RequireComponent(typeof(Collider))]
public class TriggerZone : MonoBehaviour
{
    [SerializeField] private string requiredTag = "Untagged";
    [SerializeField] private UnityEvent onActivated;
    private bool done;

    void OnTriggerEnter(Collider other)
    {
        if (done || !other.CompareTag(requiredTag)) return;
        done = true;
        Debug.Log($"{name} activado por {other.name}");
        onActivated.Invoke();
    }
}
