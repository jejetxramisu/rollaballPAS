using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    public CapsuleCollider capsuleCollider;
    public GameObject mesh;

    private void OnTriggerEnter(Collider other)
    {
        CoinText.coinValue += 5;
        Destroy(mesh);
    }
}
