using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 10f;
    private GameManager GameManager;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.startGame == false) return;

        float x = Input.GetAxis("Horizontal");
        Vector3 vector = new Vector3 (x,0,0);
        transform.Translate(vector * speed * Time.deltaTime);
        if (transform.position.x < -8)
            transform.position = new Vector3(-8f, -3.5f, 0);
        if (transform.position.x > 8)
            transform.position = new Vector3(8f, -3.5f, 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Fruit")
        {
            GameManager.score += 10;
        }

        if (other.tag == "Damage")
        {
            //game over

            Destroy(gameObject);
            GameManager.GameOver();
        }
        Destroy(other.gameObject);
    }
}
