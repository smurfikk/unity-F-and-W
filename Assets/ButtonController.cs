using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject Button2;
    public int isActivated = 0;
    public GameObject Door;
    public SpriteRenderer spriteRenderer;
    public Sprite sprite_on;
    public Sprite sprite_off;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        sprite_off = spriteRenderer.sprite;
    }

    public void Activate()
    {
        isActivated++;
        if (isActivated == 1)
        {
            Door.GetComponent<DoorController>().startLerping();
            spriteRenderer.sprite = sprite_on;
            Button2.GetComponent<SpriteRenderer>().sprite = sprite_on;
            transform.Translate(0, -0.1f, 0);
            Debug.Log("Activated");
        }
    }
    public void Deactivate()
    {
        isActivated--;
        if (isActivated == 0)
        {
            Door.GetComponent<DoorController>().startNegLerping();
            spriteRenderer.sprite = sprite_off;
            Button2.GetComponent<SpriteRenderer>().sprite = sprite_off;
            transform.Translate(0, 0.1f, 0);
            Debug.Log("Disactivated");
        }
    }

}
