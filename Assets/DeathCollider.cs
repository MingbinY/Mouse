using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCollider : MonoBehaviour
{
    bool triggered = false;

    private void Start()
    {
        triggered = false;
    }

    private void OnTriggerEnter(Collider other)
    {   
        if (triggered) return;
        if (other.GetComponent<Jump>())
        {
            Debug.Log("Death Collider");
            StartCoroutine(RestartScene());
            triggered = true;
        }
    }

    IEnumerator RestartScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
