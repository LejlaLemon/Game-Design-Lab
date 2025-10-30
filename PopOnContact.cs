using UnityEngine;

public class PopOnContact : MonoBehaviour
{
    public AudioClip ScarySound;
    private AudioSource audioSource;
    //private GameManager gameManager;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Use the modern API to find the GameManager
        //gameManager = Object.FindFirstObjectByType<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Balloon"))
        {
            // Play pop sound if available
            if (audioSource != null && ScarySound != null)
            {
              audioSource.PlayOneShot(ScarySound);
            }

            // Let the balloon handle its own pop logic
            //BalloonGrowth balloon = other.GetComponent<BalloonGrowth>();
            //if (balloon != null)
              // balloon.Pop();

            // Destroy the pin
            Destroy(gameObject, 0.05f);
            Destroy(other.gameObject, 0.05f);
        }
    }
    /* public void Pop()
    {
        //CancelInvoke(nameof(Grow));

        //if (gameManager != null)
            //gameManager.AddScore(transform.localScale.x);

        Destroy(gameObject);
    }*/
}
