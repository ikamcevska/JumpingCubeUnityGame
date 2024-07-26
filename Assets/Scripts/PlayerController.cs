using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rbody;
    public float jumpForce;
    public GameObject gameOverCanvas;
    public float restartDelay = 3f;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody>();
        gameOverCanvas.SetActive(false);
    }
    void Start()
    {

    }

  
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bridge")
        {
            gameOverCanvas.SetActive(true);
   
            StartCoroutine(RestartGameAfterDelay());

            Debug.Log("Collision with Bridge detected.");
        }
    }
    private IEnumerator RestartGameAfterDelay()
    {
        yield return new WaitForSeconds(restartDelay);
        SceneManager.LoadScene("Game");
    }
}
