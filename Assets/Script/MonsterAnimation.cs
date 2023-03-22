using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAnimation : MonoBehaviour
{
    #region Expose
    [SerializeField] private Animator _animator;
    #endregion

    #region Unity Life Cycle
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Candy"))
        {
            _animator.SetBool("isEating", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Candy"))
        {
            _animator.SetBool("isEating", false);
        }
    }
    #endregion

    #region methods

    #endregion

    #region Private & Protected

    #endregion
}
