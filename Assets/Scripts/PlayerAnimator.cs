using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerAnimator : NetworkBehaviour {


    private const string IS_WALKING = "IsWalking";


    [SerializeField] private Player player;


    private Animator animator;


    private void Awake() {
        animator = GetComponent<Animator>();
    }

    private void Update() {
        if (!IsOwner) { return; }

        HandleAnimationServerAuth();
    }

    void HandleAnimationServerAuth()
    {
        bool isWalking = player.IsWalking();
        HandleMovementServerRpc(isWalking);
    }

    [ServerRpc(RequireOwnership = false)]
    void HandleMovementServerRpc(bool isWalking)
    {
        animator.SetBool(IS_WALKING, isWalking);
    }

}