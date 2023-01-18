using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveControllerWG : MonoBehaviour
{
    public float runSpeed = 5f;
    public float jumpHeight = 6f;
    public GameObject Button1;
    public GameObject DoorWG;

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        transform.Translate(Input.GetAxis("ArrowHorizontal") * runSpeed * Time.deltaTime, 0, 0);
        transform.Translate(0, Input.GetAxis("ArrowVertical") * jumpHeight * Time.deltaTime, 0);
    }

    void Die()
    {
        SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Button1"))
        {
            Button1.GetComponent<ButtonController>().Activate();
        } else if (collision.gameObject.CompareTag("Door_wg"))
        {
            DoorWG.GetComponent<WaterDoor>().Activate();
        } else if (collision.gameObject.CompareTag("lake_l") || collision.gameObject.CompareTag("lake"))
        {
            Die();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Button1"))
        {
            Button1.GetComponent<ButtonController>().Deactivate();
        } else if (collision.gameObject.CompareTag("Door_wg"))
        {
            DoorWG.GetComponent<WaterDoor>().Deactivate();
        }
    }
}