using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bola : MonoBehaviour
{
    public float speed = 5f;

    public Text ptJG1;
    public Text ptJG2;

    void Start()
    {
        float speedX = Random.Range(0, 2) == 0 ? 1 : 1;
        float speedY = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody2D>().velocity = new Vector3(speed * speedX, speed * speedY, 0f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartScene();
        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("destroydir"))
        {
            ptJG1.text = "1";
            Destroy(this.gameObject);

            Instantiate(this.gameObject, new Vector3(0, 0, 0), Quaternion.identity);

            RestartScene();
        }

        if (collision.CompareTag("destroyesq"))
        {
            ptJG2.text = "1";
            Destroy(this.gameObject);

            Instantiate(this.gameObject, new Vector3(0, 0, 0), Quaternion.identity);

            RestartScene();
        }
    }
}
