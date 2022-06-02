using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja2 : MonoBehaviour
{
    public GameObject stand;
    public GameObject crouch;
    public float slideSpeed = 5;

    Rigidbody2D rb;

    public GameManager gameManager;

    AudioSource slideSound;
    // Start is called before the first frame update
    void Start()
    {
        slideSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("down"))
        {
            stand.SetActive(true);
            crouch.SetActive(false);

            slideSound.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "obstacle")
        {
            gameManager.GameOver();
        }
    }

    public void slideButton() {
        
            stand.SetActive(false);
            crouch.SetActive(true);
            slideSound.Play();
            stand.SetActive(true);
            crouch.SetActive(false);
        
    }
}
