using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    #region Expose
    [SerializeField] private GameObject _vicotryUI;
    #endregion

    #region Unity Life Cycle
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            _vicotryUI.SetActive(true);
        }
        else if (collision.gameObject.CompareTag("GameOver"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    #endregion
}
