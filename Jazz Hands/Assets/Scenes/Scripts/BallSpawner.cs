using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab; // The ball prefab to spawn
    public Transform spawnPoint; // The single spawn point
    public float spawnInterval = 5f; // Time between each spawn
    public int totalBalls = 10; // Total balls to spawn per cycle
    public float ballLifeTime = 30f; // Time after which the balls are destroyed

    private int currentBallCount = 0;

    void Start()
    {
        if (spawnPoint == null)
        {
            Debug.LogError("No spawn point assigned!");
            return;
        }

        StartCoroutine(SpawnBallsRoutine());
    }

    IEnumerator SpawnBallsRoutine()
    {
        while (true) // Infinite loop
        {
            currentBallCount = 0;

            while (currentBallCount < totalBalls)
            {
                SpawnBall(spawnPoint);
                currentBallCount++;

                yield return new WaitForSeconds(spawnInterval); // Wait 5 seconds before spawning next ball
            }

            // Wait for 30 seconds to destroy the balls and reset the cycle
            yield return new WaitForSeconds(ballLifeTime);

            DestroyAllBalls();
        }
    }

    void SpawnBall(Transform spawnPoint)
    {
        GameObject ball = Instantiate(ballPrefab, spawnPoint.position, spawnPoint.rotation);
        Destroy(ball, ballLifeTime); // Destroy the ball after its lifetime expires
    }

    void DestroyAllBalls()
    {
        foreach (GameObject ball in GameObject.FindGameObjectsWithTag("Ball"))
        {
            Destroy(ball);
        }
    }
}