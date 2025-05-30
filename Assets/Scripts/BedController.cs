using UnityEngine;
using UnityEngine.InputSystem;

public class BedController : MonoBehaviour
{
    private bool canSleep;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canSleep)
        {
            if (Mouse.current.leftButton.wasPressedThisFrame || Keyboard.current.spaceKey.wasPressedThisFrame || Keyboard.current.eKey.wasPressedThisFrame)
            {
                // GridInfo.instance.GrowCrop();

                if (TimeController.instance != null)
                {
                    TimeController.instance.EndDay();
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            canSleep = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            canSleep = false;
        }
    }
}
