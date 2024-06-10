using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScriptableStats: ScriptableObject
{
    [Header("Stats")]
    public float speed;
    public float jumpForce;
    public float slideSpeed = 5;
    public float wallJumpLerp = 10;
    public float dashSpeed;

}
