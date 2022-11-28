using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickController : MonoBehaviour
{

    [Header("Movement Variables")]
    [SerializeField] float speedValue;
    Vector2 movement;

    [Header("References")]
    Animator anim;
    Rigidbody2D rb;
    bool clickCheck;


    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //movement = new Vector2(0, Input.GetAxis("Vertical"));
        movement = new Vector2(0, SimpleInput.GetAxis("Vertical"));
    }
    void FixedUpdate()
    {
        StickMover(movement);
    }
    //If user clicks the left mouse button the stick starts to impale
    public void ImpaleStick()
    {
        if (!clickCheck)
        {
            FindObjectOfType<SoundManager>().Play("LassoAttack");
            anim.SetTrigger("Clicked");
            clickCheck = true;
        }
    }
    //User Movement Press W or S do move vertically
    protected void StickMover(Vector2 direction)
    {
        rb.velocity = direction * speedValue;
    }
    public void ResetBool()
    {
        clickCheck = false;
        anim.ResetTrigger("Clicked");
    }

}