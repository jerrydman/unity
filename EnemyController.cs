using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 4f;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        direction.y = 0; // Keep the enemy on the same vertical level
        transform.Translate(direction.normalized * moveSpeed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
