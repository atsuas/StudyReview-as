using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    Animator animator;

    [SerializeField] float speed;

    static int hashFront = Animator.StringToHash("Front");
    static int hashSide = Animator.StringToHash("Side");

    void Awake()
    {
        //コンポーネントと関連付け
        TryGetComponent(out animator);
    }

    void Start()
    {
        //カーソルを中央に固定（マウスを動かすゲーム用）
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //入力を取得
        var inputX = Input.GetAxis("Horizontal");
        var inputY = Input.GetAxis("Vertical");
        var leftStick = new Vector3(inputX, 0, inputY).normalized;

        //移動速度を計算
        var velocity = speed * leftStick;

        //Animatorに反映
        animator.SetFloat(hashFront, velocity.z, 0.1f, Time.deltaTime);
        animator.SetFloat(hashSide, velocity.x, 0.1f, Time.deltaTime);
    }
}
