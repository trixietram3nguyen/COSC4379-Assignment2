using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimateObject : MonoBehaviour
{
    private Button animate;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animate = GetComponent<Button>();
        animate.onClick.AddListener(startAnimation);
    }

    void startAnimation()
    {
        animator.Play("PennySpin");
    }
}
