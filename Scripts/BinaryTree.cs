using UnityEngine;

public class BinaryTree : MonoBehaviour
{
    public int rootValue = 8;
    public int insertValue = 6;
    public bool gameActive = false;

    public void StartChallenge()
    {
        gameActive = true;
        Debug.Log("Insert value: " + insertValue + ". Root value: " + rootValue);
        Debug.Log("Go LEFT if smaller, RIGHT if bigger.");
    }

    public void ChooseLeft()
    {
        if (!gameActive) return;

        if (insertValue < rootValue)
        {
            Debug.Log("Correct! Goes LEFT.");
            gameActive = false;
        }
        else
        {
            Debug.Log("Wrong direction!");
        }
    }

    public void ChooseRight()
    {
        if (!gameActive) return;

        if (insertValue > rootValue)
        {
            Debug.Log("Correct! Goes RIGHT.");
            gameActive = false;
        }
        else
        {
            Debug.Log("Wrong direction!");
        }
    }
}