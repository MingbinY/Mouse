using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDetection : MonoBehaviour
{
    GroundCheck gc;
    public float maxFallTime = 1f;
    [SerializeField] float fallTimer = 0f;

    private void Start()
    {
        gc = GetComponent<GroundCheck>();
    }

    private void FixedUpdate()
    {
        if (gc.isGrounded)
        {
            if (fallTimer != 0f)
            {
                Debug.Log(fallTimer);
            }
            fallTimer = 0;
            return;
        }
        fallTimer += Time.deltaTime;
        if (fallTimer >= maxFallTime)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
