﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class SpartaAnimationController : AnimationController
{
    Player player;
    private static readonly int isWalking = Animator.StringToHash("isWalking");
    private static readonly int isHit = Animator.StringToHash("isHit");
    private static readonly int Attack = Animator.StringToHash("attack");

    private readonly float magnituteThreshold = 0.5f;
    protected override void Awake()
    {
        base.Awake();
        player = GetComponent<Player>();

    }

    private void Start()
    {
        if (controller != null)
        {
            controller.OnMoveEvent += Move;
        }
    }

    private void Move(Vector2 vector)
    {
        player.animator.SetBool(isWalking, vector.magnitude > magnituteThreshold);
    }
}