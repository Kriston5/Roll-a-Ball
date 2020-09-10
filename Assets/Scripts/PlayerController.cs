using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float moveX, moveY;
    private int count;

    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        count = 0;

        setCountText();

        winText.SetActive(false);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        moveX = movementVector.x;
        moveY = movementVector.y;
    }

    void setCountText()
    {
        countText.text = "Score: " + count.ToString();

        winText.SetActive(count >= 12);
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveX, 0.0f, moveY);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);

            count++;

            setCountText();
        }
    }

}
