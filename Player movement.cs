using UnityEngine;
using TMPro; 

public class DialogTrigger : MonoBehaviour
{
    public GameObject dialogBox; // Reference to the dialog UI
    public TextMeshProUGUI dialogText; // Reference to the text inside the UI
    public string message = "I need to enter through this door without being seen."; // The dialog message

    private void Start()
    {
        dialogBox.SetActive(false); // Hide dialog initially
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("student")) // Make sure the player has the "Player" tag
        {
            dialogBox.SetActive(true);
            dialogText.text = message;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("student"))
        {
            dialogBox.SetActive(false);
        }
    }
}
