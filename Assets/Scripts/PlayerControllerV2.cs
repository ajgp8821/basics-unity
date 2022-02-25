using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerV2 : MonoBehaviour {

    bool canJump = false;
    

    // Start is called before the first frame update
    void Start() {
        gameObject.GetComponent<Rigidbody2D>().freezeRotation = true;
    }

    // Update is called once per frame
    void Update() {
        float tdt = Time.deltaTime;
        if (Input.GetKey("left")) {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-500 * tdt, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey("right")) {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(500 * tdt, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (!Input.GetKey("left") && !Input.GetKey("right")) {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }
        if (Input.GetKeyDown("up") && canJump) {
            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.transform.tag == "ground") {
            canJump = true;
        }
    }
}
