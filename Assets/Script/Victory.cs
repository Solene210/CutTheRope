using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Victory : MonoBehaviour
{
    #region Expose
    
    #endregion

    #region Unity Life Cycle
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Debug.Log("Victoire");
        }
        else if (collision.gameObject.CompareTag("GameOver"))
        {
            Destroy(gameObject);
            Debug.Log("Defaite");
        }
    }
    #endregion

    #region methods

    #endregion

    #region Private & Protected

    #endregion
}
