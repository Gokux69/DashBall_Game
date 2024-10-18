using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ball : MonoBehaviour
{
    public float keyelemnt;
    public float verticalInput;
    public Vector3 startingPosition;
    public int maxRespawns = 3;
    private int collisionCount = 0;
    private Vector3 initialPosition;
    private Vector3 lastPosition;
    private bool isInvincible = false;
    public float invincibilityDuration = 2f;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        initialPosition = transform.position;
        lastPosition = initialPosition;
    }

    void Update()
    {
        keyelemnt = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(keyelemnt * 5f, rb.velocity.y, verticalInput * 5f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 3, ForceMode.VelocityChange);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") && !isInvincible)
        {
            StartCoroutine(InvincibilityCoroutine());
            HandleRespawn();

            healthmanager.health--;
            if (healthmanager.health <= 0)
            {
                return;
            }
        }
        else if (collision.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private IEnumerator InvincibilityCoroutine()
    {
        isInvincible = true;
        yield return new WaitForSeconds(invincibilityDuration);
        isInvincible = false;
    }

    private void HandleRespawn()
    {
        collisionCount++;

        if (collisionCount > maxRespawns)
        {
            transform.position = initialPosition;
            collisionCount = 0;
        }
    }
}