using UnityEngine;
using Lightbug.CharacterControllerPro.Core;
using Lightbug.Utilities;
using Lightbug.CharacterControllerPro.Implementation;
using Lightbug.CharacterControllerPro.Demo;
using System.Collections;
using System.Collections.Generic;


public class MovimentMode01 : NormalMovement
{


    [Header("Animation")]

    [SerializeField]
    protected string jumpRange = "JumpRange";
    protected int ValJumpRange = 0;
    protected int TimeNoChao = 0;
    [SerializeField]
    protected string groundedParam = "Grounded";

    public List<int> JumpAnims = new List<int>();

    protected override void Start()
    {
        base.Start();

        JumpAnims.Add(1);
        JumpAnims.Add(2);
        JumpAnims.Add(3);
        JumpAnims.Add(4);
    }

    protected override void Awake()
    {
        base.Awake();

    }

    // Update is called once per frame
    public void Update()
    {
        
    }


    void FixedUpdate()
    {

        /* Este script muda a animação em sequencia de pulo
        if (!CharacterStateController.Animator.GetBool(groundedParam))
        {
            ValJumpRange = CharacterStateController.Animator.GetInteger(jumpRange);
            TimeNoChao = 0;
        }
        else
        {
            TimeNoChao += 1;

            if(TimeNoChao == 1)
                ValJumpRange += 1;

            if (TimeNoChao > 60)
                ValJumpRange = 0;
        }

        CharacterStateController.Animator.SetInteger(jumpRange, ValJumpRange);
        */

    }

    public override void CheckExitTransition()
    {
        base.CheckExitTransition();
        if (CharacterStateController.Animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            // CharacterStateController.EnqueueTransition<FireBombNormalMoviment>();
        }
    }


    bool isPlaying(int animLayer, string stateName)
    {
        if (CharacterStateController.Animator.GetCurrentAnimatorStateInfo(animLayer).IsName(stateName) &&
                CharacterStateController.Animator.GetCurrentAnimatorStateInfo(animLayer).normalizedTime < 1.0f)
            return true;
        else
            return false;
    }
}
