using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject activeIndicator;
    public float moveSpeed = 0.02f;

    private Animator animator;
    private Vector3 moveDirection;

    private void Awake ()
    {
        animator = GetComponent<Animator> ();
    }

    private void Update ()
    {
        transform.position += moveDirection * moveSpeed;
    }

    private void OnMouseDown ()
    {
        PlayerSelectionManager.Instance.SelectPlayer (this);
    }

    public void MoveForward ()
    {
        moveDirection = Vector3.forward;
        transform.eulerAngles = Vector3.up * 0;
        animator.SetTrigger ("Walk");
    }

    public void MoveBack ()
    {
        moveDirection = -Vector3.forward;
        transform.eulerAngles = Vector3.up * 180;
        animator.SetTrigger ("Walk");
    }

    public void MoveRight ()
    {
        moveDirection = Vector3.right;
        transform.eulerAngles = Vector3.up * 90;
        animator.SetTrigger ("Walk");
    }

    public void MoveLeft ()
    {
        moveDirection = -Vector3.right;
        transform.eulerAngles = Vector3.up * -90;
        animator.SetTrigger ("Walk");
    }

    public void Stop ()
    {
        moveDirection = Vector3.zero;
        animator.SetTrigger ("Normal");
    }
}