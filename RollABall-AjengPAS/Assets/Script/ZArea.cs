using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZArea : MonoBehaviour
{
    

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        CoinText.coinValue = 0;
    }
}
