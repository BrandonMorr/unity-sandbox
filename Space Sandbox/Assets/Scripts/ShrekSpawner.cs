using UnityEngine;

public class ShrekSpawner : MonoBehaviour
{
    public GameObject ShrekPrefab;

    // Spawn zone controls
    public Vector3 center;
    public Vector3 size;

    void Awake()
    {
        for (int i = 0; i <= 10; i++) 
        {
            SpawnShreks();
        }
    }

    // Spawn the damn ogres
    public void SpawnShreks()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

        Instantiate(ShrekPrefab, pos, Quaternion.identity);
    }

    // Show the spawn zone in the scene editor
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 1, 1, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
