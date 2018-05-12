using UnityEngine;
using System.Collections;

public class PlayerAnimationController : MonoBehaviour {
    
    Animator animator;
    int jumpHash = Animator.StringToHash("Jump");
    int runHash = Animator.StringToHash("Running");

	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");

        animator.SetBool(runHash, (horizontal != 0 || vertical != 0));
        if (jump==1)
            animator.SetTrigger(jumpHash);
    }
}
