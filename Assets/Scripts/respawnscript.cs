using UnityEngine;

public class respawnscript : MonoBehaviour
{
    [SerializeField] Transform spawn;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 vector = new Vector3(0, 0, 0);

            other.attachedRigidbody.position = spawn.transform.position;
            other.attachedRigidbody.rotation = spawn.transform.rotation;
            other.attachedRigidbody.linearVelocity = vector;
        }
    }
}
