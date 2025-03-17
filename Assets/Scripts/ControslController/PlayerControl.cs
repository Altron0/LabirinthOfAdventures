using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] Joystick left;

    [SerializeField] Joystick right;
    [SerializeField, Range(1, 100f)] float speedMove;
    [SerializeField, Range(1, 100f)] float speedRotation;

    private void Update()
    {
        movePlayer();
    }

    void movePlayer() 
    {
        transform.TryGetComponent(out Rigidbody player);

        Vector3 move =
            (player.transform.right * left.unlimitedLocalPositionEnd.x) +
            (Vector3.zero) +
            (player.transform.forward * left.unlimitedLocalPositionEnd.y);
        player.velocity = move * speedMove;
        transform.Rotate(Vector3.up * right.unlimitedLocalPositionEnd.x / 1000f * speedRotation);
    }
}
