using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MigajaDePanScript : MonoBehaviour
{
    //Lista de posisiones anteriores
    public List<Vector3> posicionesAnteriores = new List<Vector3>();
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        posicionesAnteriores.Add(transform.position);
    }
}
