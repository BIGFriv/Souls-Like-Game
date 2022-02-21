using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ResetAnimatorBool : StateMachineBehaviour
{
  public string targetBool;
  public bool status;

    int tick = 0;

  public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
  {
      animator.SetBool(targetBool, status);
        Debug.Log("isInteracting reset" + tick++);
  }

}
