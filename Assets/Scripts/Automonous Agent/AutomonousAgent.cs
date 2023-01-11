using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomonousAgent : Agent
{
    void Update()
    {
        var gameObjects = perception.GetGameObjects();
        foreach (var gameObject in gameObjects)
        {
            Debug.DrawLine(transform.position, gameObject.transform.position);
        }
        if (gameObjects.Length > 0)
        {
            Vector3 direction = (gameObjects[0].transform.position - transform.position).normalized;
            movement.ApplyForce(direction * 2);
        }

        transform.position = Utilities.Wrap(transform.position, Vector3.one * -10, Vector3.one * 10);
    }
}
