using System.Collections;
using UnityEngine;

// THIS CLASS START TO SPAWN ENEMIES ATTACKER 
public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] Attacker attackerPrefab;
    [SerializeField] float minSpawnDelay = 1.0f;
    [SerializeField] float maxSpawnDelay = 5.0f;
    bool spawn = true; //To control spawning at the start and the end of the level
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }
    private void SpawnAttacker()
    {
        Instantiate(attackerPrefab, transform.position, transform.rotation);
    }

}
