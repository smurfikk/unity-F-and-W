using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveControllerFM : MonoBehaviour
{
    public float runSpeed = 5f;
    public float jumpHeight = 6f;
    public GameObject Button1;
    public GameObject DoorWG;
    public GameObject DoorFM;

    void Update()
    {
        Movement();
        if (DoorFM.GetComponent<FireDoor>().isActivated && DoorWG.GetComponent<WaterDoor>().isActivated)
        {
            SceneManager.LoadScene(1);
        }
    }

    void Movement()
    {
        transform.Translate(Input.GetAxis("Horizontal") * runSpeed * Time.deltaTime, 0, 0);
        transform.Translate(0, Input.GetAxis("Vertical") * jumpHeight * Time.deltaTime, 0);
    }

    void Die()
    {
        SceneManager.LoadScene(1);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Button1"))
        {
            Button1.GetComponent<ButtonController>().Activate();
        } else if (collision.gameObject.CompareTag("Door_fm"))
        {
            DoorFM.GetComponent<FireDoor>().Activate();
        } else if (collision.gameObject.CompareTag("lake_w") || collision.gameObject.CompareTag("lake"))
        {
            Die();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Button1"))
        {
            Button1.GetComponent<ButtonController>().Deactivate();
        } else if (collision.gameObject.CompareTag("Door_fm"))
        {
            DoorFM.GetComponent<FireDoor>().Deactivate();
        }
    }
}