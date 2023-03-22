using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsPickUp : MonoBehaviour
{
    #region Expose
    [SerializeField] private StarCount _starCount;
    #endregion

    #region Unity Life Cycle
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Candy"))
        {
            _starCount._stars--;
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
    #endregion

    #region methods

    #endregion

    #region Private & Protected

    #endregion
}
