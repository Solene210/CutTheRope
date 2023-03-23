using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsPickUp : MonoBehaviour
{
    #region Expose
    [SerializeField] private StarCount _starCount;
    [SerializeField] private IntVariable _nbStar;
    [SerializeField] private int _score;
    #endregion

    #region Unity Life Cycle
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Candy"))
        {
            _starCount._stars--;
            _nbStar._value += _score;
            gameObject.SetActive(false);
        }
    }
    #endregion
}
