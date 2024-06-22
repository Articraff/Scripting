using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 1;
    public int level = 4;
    public float speed = 4f;

    void Start()
    {
        // Adds the level to the health
        health += level;
        // Outputs the health value to the console
        print("New Health: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        // Create variable new position and set it to the NPCs current position
        Vector3 newPosition = transform.position;
        // Add the speed to the new position
        newPosition.z += speed * Time.deltaTime;
        // Set the NPCs position
        transform.position = newPosition;

    }
}
