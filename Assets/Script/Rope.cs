using UnityEngine;

public class Rope : MonoBehaviour
{
    #region Expose
    [SerializeField] private Rigidbody2D _hook;
    [SerializeField] private GameObject _linkPrefab;
    [SerializeField] private int links = 7;
    public Weight weight;
    #endregion

    #region Unity Life Cycle
    void Start()
    {
        GenerateRope();
    }

    void Update()
    {
        
    }
    #endregion

    #region methods
    private void GenerateRope()
    {
        Rigidbody2D previousRB = _hook;
        for (int i = 0; i < links; i++)
        {
            GameObject link = Instantiate(_linkPrefab, transform);
            HingeJoint2D joint = link.GetComponent<HingeJoint2D>();
            joint.connectedBody = previousRB;
            if (i < links - 1)
            {
                previousRB = link.GetComponent<Rigidbody2D>();
            }
            else
            {
                weight.ConnectRopeEnd(link.GetComponent<Rigidbody2D>());
            }
        }
    }
    #endregion

    #region Private & Protected
    
    #endregion
}
