using UnityEngine;

// Sube una compuerta (o puerta) suavemente cuando se llama a Open().
public class DoorOpener : MonoBehaviour
{
    [SerializeField] private Vector3 openOffset = new Vector3(0f, 2f, 0f);
    [SerializeField] private float speed = 2f;
    private Vector3 target;
    private bool opening;

    public void Open()
    {
        target = transform.position + openOffset;
        opening = true;
    }

    void Update()
    {
        if (opening)
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
