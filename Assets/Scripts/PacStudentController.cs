using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Animator animator;
    private Vector2 movement;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Get player input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Set animation parameters
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);

        // Prevent diagonal movement by normalizing the vector
        if (movement.magnitude > 1)
        {
            movement.Normalize();
        }

        // Move the character
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
