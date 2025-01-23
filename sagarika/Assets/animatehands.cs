using UnityEngine;

public class AnimateHands : MonoBehaviour
{
    // Reference to the Animator component
    public Animator animator;

    void Update()
    {
        // Check if the player presses the 'H' key
        if (Input.GetKeyDown(KeyCode.H)) // You can change 'H' to another key if desired
        {
            // Play the animation called "LowerHands"
            animator.Play("LowerHands");
        }
    }
}


public class CSharpScript
{
    
}
