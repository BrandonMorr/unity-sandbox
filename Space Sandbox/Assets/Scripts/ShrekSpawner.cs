using UnityEngine;

public class ShrekSpawner : MonoBehaviour
{
    public GameObject ShrekPrefab;

    public int numberOfShreks = 10;

    public Vector3 center;
    public Vector3 size;

    public bool enableSpawner = true;

    void Awake()
    {
        if (enableSpawner)
        {
            for (int i = 0; i <= numberOfShreks; i++)
            {
                SpawnShreks();
            }
        }
    }

    // Spawn the damn ogres
    public void SpawnShreks()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Quaternion rot = Quaternion.Euler(new Vector3(Random.Range(1f, 360f), Random.Range(1f, 360f), Random.Range(1f, 360f)));

        Instantiate(ShrekPrefab, pos, rot);
    }

    // Show the spawn zone in the scene editor
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
