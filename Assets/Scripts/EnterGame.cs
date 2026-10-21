using UnityEngine;

public class EnterGame : MonoBehaviour
{
    public Canvas GameMenu;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.transform.root.CompareTag("Player"))
        {
            return;
        }

        if (GameMenu == null)
        {
            Debug.LogError("GameMenu is not assigned on EnterGame.", this);
            return;
        }

        GameMenu.gameObject.SetActive(true);
        GameMenu.enabled = true;
        Time.timeScale = 0f;
    }
}