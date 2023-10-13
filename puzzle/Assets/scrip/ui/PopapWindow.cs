using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopapWindow : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        animator.SetTrigger("o");
    }

    public void Closepopup()
    {
        animator.SetTrigger("c");
        Invoke("c", 0.3f);
    }

    void c()
    {
        gameObject.SetActive(false);
    }

}
