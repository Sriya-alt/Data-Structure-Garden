using UnityEngine;

public class ChoiceZone : MonoBehaviour
{
    public BinaryTree game;
    public bool isLeft = true; // tick for LeftChoice, untick for RightChoice

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        if (isLeft) game.ChooseLeft();
        else game.ChooseRight();
    }
}