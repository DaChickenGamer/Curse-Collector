using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class TombstoneSpawner : MonoBehaviour
{
    public Vector2 startingSpawnPos = new (-7.5f, 0);
    public Vector2 offset = new (1, 1);

    public Vector2 gridSize = new Vector2();
    
    public GameObject tombstonePrefab;
    public Sprite[] tombstoneSprites;

    private List<GameObject> tombstones;
    
    void Start()
    {
        GenerateTombstone();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateTombstone()
    {
        for (var x = 0; x < gridSize.x; x++)
        {
            for (var y = 0; y < gridSize.y; y++)
            {
                var newTombstone = Instantiate(tombstonePrefab, new Vector2(startingSpawnPos.x + x * offset.x, startingSpawnPos.y + y * offset.y), Quaternion.identity, transform);
                newTombstone.GetComponent<SpriteRenderer>().sprite = tombstoneSprites[Random.Range(0, tombstoneSprites.Length)];
                newTombstone.name = "Tombstone_" + x + "_" + y;
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        
        for (var x = 0; x < gridSize.x; x++)
        {
            for (var y = 0; y < gridSize.y; y++)
            {
                Gizmos.DrawWireCube(new Vector3(startingSpawnPos.x + x * offset.x, startingSpawnPos.y + y * offset.y, 0), Vector3.one);
            }
        }
    }
}
