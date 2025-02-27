﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArmAnimatorFix : MonoBehaviour {
    private Animator animator;
    private PlayerController plac;
    public Vector3 a;

    void Awake () {
        animator = GetComponent<Animator> ();
        plac = GetComponentInParent<PlayerController> ();
    }

    void OnAnimatorIK () {
        if (plac.leftIsShield) {
            if (animator.GetBool ("defense") == false) {
                Transform lefLowerArm = animator.GetBoneTransform (HumanBodyBones.LeftLowerArm);
                lefLowerArm.localEulerAngles += a;
                animator.SetBoneLocalRotation (HumanBodyBones.LeftLowerArm, Quaternion.Euler (lefLowerArm.localEulerAngles));
            }
        }
    }
}