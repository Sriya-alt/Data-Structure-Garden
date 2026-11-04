using UnityEngine;

public class InteractTrigger : MonoBehaviour
{
    public BinaryTree game;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Press E to start Binary Tree Challenge");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            game.StartChallenge();
        }
    }
}