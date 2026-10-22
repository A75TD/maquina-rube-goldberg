using UnityEngine;

// Da el impulso inicial a la primera bola al presionar ESPACIO.
[RequireComponent(typeof(Rigidbody))]
public class StartPusher : MonoBehaviour
{
    [SerializeField] private Vector3 impulse = new Vector3(2f, 0f, 0f);
    private Rigidbody rb;
    private bool launched;

    void Awake() => rb = GetComponent<Rigidbody>();

    void Update()
    {
        if (!launched && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(impulse, ForceMode.Impulse);
            launched = true;
            Debug.Log("Maquina iniciada");
        }
    }
}
