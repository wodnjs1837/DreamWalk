using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    Rigidbody2D rb;
    public float v;
    public float jump_power;
    private bool isJumping;
    public KeyCode key;

    private AudioSource bgm;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        isJumping = false;
        bgm = this.GetComponent<AudioSource>();
        bgm.Play();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(key)) {
            Debug.Log("down");
            isJumping = true;
        }
        if (Input.GetKeyUp(key)) {
            isJumping = false;
        }
        Debug.Log("???");
        rb.velocity = new Vector2(v, rb.velocity.y);
	}

    void Jump() {
        if (isJumping) {
            rb.AddForce(new Vector2(0, jump_power));
            isJumping = false;
        }
    }

    void FixedUpdate() {
        Jump();
    }
}
