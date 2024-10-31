using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    GameSetting GameSetting;
    private float moveSpeed;
    [SerializeField] private Animator animator;

    private void Awake()
    {
        GameSetting = FindObjectOfType<GameSetting>();
    }

    void Start()
    {
        moveSpeed = GameSetting.MoveSpeed;
    }


    public void MoveCharacter(float hm)
    {
        transform.Translate(Vector3.right * hm * Time.deltaTime * moveSpeed);

        if (transform.position.x < -2.4f) transform.position = new Vector3(-2.4f, 0, 0);
        if (transform.position.x > 15) transform.position = new Vector3(15, 0, 0);

        Animation(hm);
    }

    private void Animation(float horizontalInput)
    {
        if (horizontalInput < 0)
        {
            animator.Play("CarAnimLeft");
        }
        else if (horizontalInput > 0)
        {
            animator.Play("CarAnimRight");
        }
        else
        {
            // Переход в idle состояние
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("CarAnimLeft"))
            {
                animator.Play("CarAnimLeftIdle");
            }
            else if (animator.GetCurrentAnimatorStateInfo(0).IsName("CarAnimRight"))
            {
                animator.Play("CarAnimRightIdle");
            }
        }
    }
}