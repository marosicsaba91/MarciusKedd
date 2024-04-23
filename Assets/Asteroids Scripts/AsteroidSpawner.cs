using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] int spawnCount;
    [SerializeField] Asteroid[] asteroidPrefabs;
    [SerializeField] float spawnDistance = 5;

    List<Asteroid> asteroids = new();  // Amik a Scene-ben léteznek

    void Start()
    {
        Spawn();
    }


    void Spawn()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            int randomIndex = Random.Range(0, asteroidPrefabs.Length);
            Asteroid prefab = asteroidPrefabs[randomIndex];
            Asteroid newAsteroid = Instantiate(prefab);
            asteroids.Add(newAsteroid);

            Vector2 position = Random.insideUnitCircle;
            position.Normalize();
            position *= spawnDistance;

            newAsteroid.transform.position = position;
        }
    }

    public void RemoveAsteroid(Asteroid asteroid)
    {
        asteroids.Remove(asteroid);
        if (asteroids.Count == 0)
        {
            Debug.Log("STAGE CLEARED!");
            Spawn();
        }
    }
}
