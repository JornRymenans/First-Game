using UnityEngine;

public class playerColllision : MonoBehaviour
{
    public PlayerMovement movement;     // A reference to our PlayerMovement script

    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".
    void OnCollisionEnter(Collision collisionInfo)
    {
        // We check if the object we collided with has a tag called "Obstacle".
        if (collisionInfo.collider.tag == "Obsticle")
        {
            movement.enabled = false;   // Disable the players movement.
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
